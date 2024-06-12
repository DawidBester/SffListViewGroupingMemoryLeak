
namespace SfListViewGroupingMemoryLeak;

public partial class MainPageLauncher : ContentPage
{
    public MainPageLauncher()
    {
        InitializeComponent();
    }

    private async void MainPageLauncherButton_OnClicked(object? sender, EventArgs e)
    {
        var mainPage = nameof(MainPage);

        await Shell.Current.GoToAsync($"{mainPage}");
    }
}