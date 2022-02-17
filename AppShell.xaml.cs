namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(ForecastPage), typeof(ForecastPage));
		Routing.RegisterRoute(nameof(AddForecastPage), typeof(AddForecastPage));
		Routing.RegisterRoute(nameof(AppShell), typeof(AppShell));
	}
}