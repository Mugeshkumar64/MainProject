using MainProject.viewModel;

namespace MainProject.view;

public partial class LoginNowPage : ContentPage
{
    public LoginNowViewModel viewModel { get; set; }
    public LoginNowPage()
	{
		InitializeComponent();
		var viewmodel = new LoginNowViewModel();
		BindingContext = viewmodel; 
        MessagingCenter.Subscribe<LoginMainPageViewModel>(this, "ShowWrong", async (sender) =>
        {
           await DisplayAlert("Alert", "Credintials is wrong", "OK");
        });
        MessagingCenter.Subscribe<LoginMainPageViewModel>(this, "ShowEmail", async (sender) =>
        {
           await DisplayAlert("Alert", "Email is incorrect", "OK");
        });
        MessagingCenter.Subscribe<LoginMainPageViewModel>(this, "ShowPassword", async (sender) =>
        {
            await DisplayAlert("Alert", "Password is incorrect", "OK");
        });
        
    }
}