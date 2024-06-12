using Microsoft.Extensions.Configuration;

namespace SfListViewGroupingMemoryLeak
{
    public partial class App : Application
    {
        public App(IConfiguration config)
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
