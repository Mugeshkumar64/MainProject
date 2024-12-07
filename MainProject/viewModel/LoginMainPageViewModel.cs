using MainProject.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainProject.viewModel
{
     public class LoginMainPageViewModel
    {
        public string WelcomeMessage { get; set; }

        public DateTime StartDate { get; set; }
        public ICommand LoginNowCommand { get; set; }
        public LoginMainPageViewModel()
        {
            WelcomeMessage = "WELCOME!";
            LoginNowCommand = new Command(GoToLoginNowPage);
        }

        public  void  GoToLoginNowPage()
        {
            //MessagingCenter.Send(this, "ShowAlert");
            //await Shell.Current.GoToAsync(nameof(LoginMainPage));
            // await Shell.Current.GoToAsync("///LoginNowPage");
             App.Current.MainPage = new LoginNowPage();
        }


    }
}
