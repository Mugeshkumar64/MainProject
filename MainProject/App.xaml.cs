using MainProject.view;

namespace MainProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //  MainPage = new AppShell();
            // MainPage = new CodeBehiondCreation();
            MainPage = new MainPage();
        }
    }
}
