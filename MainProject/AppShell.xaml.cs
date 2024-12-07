using MainProject.view;

namespace MainProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(("LoginMainPage"), typeof(LoginMainPage));
            Routing.RegisterRoute(nameof(LoginNowPage), typeof(LoginNowPage));
            
        }
    }
}
