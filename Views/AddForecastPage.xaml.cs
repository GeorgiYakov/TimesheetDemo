namespace MauiApp1;

public partial class AddForecastPage : ContentPage
{
    string chosenProj = "";
    DateTime date = DateTime.MinValue;
	public AddForecastPage()
	{
		InitializeComponent();

        projPicker.ItemsSource = ProjectsList.GetPojects().Select(p => p.Title).ToList();

    }

    private async void OnAddClick(object sender, EventArgs e)
    {
        chosenProj = projPicker.SelectedItem.ToString();

        Forecast f = new Forecast { Date = date, NumOfDays = Int32.Parse(numDays.Text), ProjectName = chosenProj };
        Application.Current.Properties["Forecast"] = f;
        await Shell.Current.GoToAsync("..");
    }
    private async void OnCancelClick(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        date = ForecastDate.Date;
    }
}