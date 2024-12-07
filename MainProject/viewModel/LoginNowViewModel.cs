using MainProject.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MainProject.viewModel
{
    public partial class LoginNowViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        
        public ICommand LoginCommand { get; set; }
        public ICommand BackButtonCommand { get; set; }
        public LoginNowViewModel()
        {
            Email = "mugesh123@gmail.com";
            Password = "Mugesh@123";
            LoginCommand = new Command(GoToHomePage);
            BackButtonCommand = new Command(GoToPrevoiusPage);
        }

#if ANDROID


#endif
        public async void GoToHomePage()
        {
            if(Email != null && Password !=null)
            {
                if(Email == "mugesh123@gmail.com")
                {
                    if(Password == "Mugesh@123")
                    {
                        await Shell.Current.DisplayAlert("alert", "valdtion", "sucess");
                        //await Shell.Current.GoToAsync("///HomePage");
                       
                    }
                    else
                    {
                        MessagingCenter.Send(this, "ShowPassword");
                    }
                }
                else
                {
                    MessagingCenter.Send(this, "ShowEmail");
                    
                }

            }
            else
            {
                MessagingCenter.Send(this, "ShowWrong");
            }
        }

        public async void GoToPrevoiusPage()
        {
            await Shell.Current.GoToAsync("LoginMainPage");
        }
    }
}
