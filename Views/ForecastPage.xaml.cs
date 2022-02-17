namespace MauiApp1;

public partial class ForecastPage : ContentPage
{
	List<Forecast> forecastList;
	public ForecastPage()
	{
		InitializeComponent();

		forecastList = new List<Forecast>
		{
			new Forecast{
				Date = new DateTime(2022,2,7),
				NumOfDays = 3,
				ProjectName = "Software Development",
			},
			new Forecast{
				Date = new DateTime(2022,2,1),
				NumOfDays = 5,
				ProjectName = "Debugging",
			},
			new Forecast{
				Date = new DateTime(2022,5,18),
				NumOfDays = 7,
				ProjectName = "Coding",
			},
			new Forecast{
				Date = new DateTime(2022,7,25),
				NumOfDays = 10,
				ProjectName = "Holiday",
			},
			new Forecast{
				Date = new DateTime(2022,7,25),
				NumOfDays = 10,
				ProjectName = "Holiday",
			},
		};
		Application.Current.Properties["Forecast"] = null;
		if (Application.Current.Properties["Forecast"] != null)
        {
			forecastList.Add((Forecast)Application.Current.Properties["Forecast"]);
			ForecastListView.ItemsSource = null;
			ForecastListView.ItemsSource = forecastList;
		}

		ForecastListView.ItemsSource = forecastList; 


	}


    private async void OpenForecastWindow(object sender, EventArgs e)
    {
        var route = $"{nameof(AddForecastPage)}";
		await Shell.Current.GoToAsync(route);

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		testLabel.Text = Application.Current.Properties["Forecast"].ToString();
		forecastList.Add((Forecast)Application.Current.Properties["Forecast"]);
		ForecastListView.ItemsSource = null;
		ForecastListView.ItemsSource = forecastList;
	}
}