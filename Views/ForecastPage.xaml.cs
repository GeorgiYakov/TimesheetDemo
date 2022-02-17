using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class ForecastPage : ContentPage
{
	ObservableCollection<Forecast> forecastList;
	public ForecastPage()
	{
		InitializeComponent();

		forecastList = new ObservableCollection<Forecast>
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
		

		ForecastListView.ItemsSource = forecastList; 


	}
	protected override void OnAppearing()
	{
		if (Application.Current.Properties["Forecast"] != null)
		{
			forecastList.Add((Forecast)Application.Current.Properties["Forecast"]);
		}
	}


	private async void OpenForecastWindow(object sender, EventArgs e)
    {
        var route = $"{nameof(AddForecastPage)}";
		await Shell.Current.GoToAsync(route);

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ForecastListView.ItemsSource = null;
		ForecastListView.ItemsSource = forecastList;
	}
}