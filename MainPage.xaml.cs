using SfListViewGroupingMemoryLeak.ViewModels;

using Syncfusion.Maui.DataSource;


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
