namespace MauiApp1;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
		var route = $"{nameof(AppShell)}";
		Console.WriteLine("button is clicked");

		App.Current.MainPage = new AppShell();
        //await Navigation.PushAsync(new AppShell());
		
	}
}