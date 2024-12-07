using MainProject.viewModel;

namespace MainProject.view;

public partial class LoginMainPage : ContentPage
{

	public LoginMainPage()
	{
		InitializeComponent();
		var viewmodel = new LoginMainPageViewModel();
		BindingContext = viewmodel;
        //MessagingCenter.Subscribe<LoginMainPageViewModel>(this, "ShowAlert", async (sender) =>
        //{
        //    await DisplayAlert("Alert", "You have been alerted", "OK");
        //});
    }

    // Make sure to unsubscribe to prevent memory leaks
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        //MessagingCenter.Unsubscribe<LoginMainPageViewModel>(this, "ShowAlert");
    }
}