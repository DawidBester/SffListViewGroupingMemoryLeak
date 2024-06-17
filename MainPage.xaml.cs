using SfListViewGroupingMemoryLeak.ViewModels;

using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.ListView.Helpers;

using System.Reflection;


namespace SfListViewGroupingMemoryLeak
{
    public partial class MainPage : ContentPage
    {
        private BookInfoRepository _bookInfoRepository;
        public MainPage()
        {
            _bookInfoRepository = Application.Current.Handler.MauiContext.Services.GetService<BookInfoRepository>();
            BindingContext = _bookInfoRepository;

            InitializeComponent();

            BookInfoSfListView.DataSource?.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ExerciseSetName",
                KeySelector = (object obj1) =>
                {
                    var item = ((BookInfo)obj1);
                    return item; //.Category;
                }

            });
        }



        protected override void OnDisappearing()

        {

            var visualTree = BookInfoSfListView.GetVisualTreeDescendants();

            foreach (var item in visualTree)
            {
                if (item is SfListView listView)
                {

                    var method = listView.GetType().GetRuntimeMethods().Where(x => x.Name == "UnWireEvents")
                        .FirstOrDefault();

                    if (method != null) method.Invoke(listView, null);

                    listView.Handler?.DisconnectHandler();

                    listView.GetVisualContainer().Handler?.DisconnectHandler();

                    listView.Children.Clear();

                    listView.GetVisualContainer().Children.Clear();

                    listView.GetVisualContainer().GetType().GetRuntimeProperties().Where(x => x.Name == "Parent")
                        .FirstOrDefault().SetValue(listView.GetVisualContainer(), null);

                    listView.GetType().GetRuntimeProperties().Where(x => x.Name == "VisualContainer").FirstOrDefault()
                        .SetValue(listView, null);

                    listView = null;
                }
            }


            ////var methodTwo = BookInfoSfListView.GetType().GetRuntimeMethods().Where(x => x.Name == "UnWireEvents")
            ////    .FirstOrDefault();

            ////if (methodTwo != null) methodTwo.Invoke(BookInfoSfListView, null);

            //BookInfoSfListView.Handler?.DisconnectHandler();

            ////BookInfoSfListView.GetVisualContainer().Handler?.DisconnectHandler();

            //BookInfoSfListView.Children.Clear();

            ////BookInfoSfListView.GetVisualContainer().Children.Clear();

            ////BookInfoSfListView.GetVisualContainer().GetType().GetRuntimeProperties().Where(x => x.Name == "Parent")
            ////    .FirstOrDefault().SetValue(BookInfoSfListView.GetVisualContainer(), null);

            //BookInfoSfListView.GetType().GetRuntimeProperties().Where(x => x.Name == "VisualContainer").FirstOrDefault()
            //    .SetValue(BookInfoSfListView, null);

            //BookInfoSfListView = null;

            base.OnDisappearing();

        }


        private void Button_OnClicked(object? sender, EventArgs e)
        {
            var key = (sender as Button)?.CommandParameter;

            var book = (BookInfo)key;

            var group = _bookInfoRepository.BookInfoCollection.FirstOrDefault(x => x == book);

            if (group != null) group.IsExpanded = !group.IsExpanded;
        }

        private async void BackButton_OnClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }

}
