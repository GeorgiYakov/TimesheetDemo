namespace MauiApp1;

public partial class WorkdaysPage : ContentPage
{
	public WorkdaysPage()
	{
		InitializeComponent();

		federalStatePicker.ItemsSource = new List<string> { "Baden-Wüttemberg", "Bayern", "Berlin", "Brandenburg", "Bremen","Hamburg", "Hessen", "Mecklenburg-Vorpommern",
		"Niedersaches", "Nordhein-Westfalen", "Rheinland-Platz", "Saarland", "Sachsen", "Sachsen-Anhalt", "Schleswig-Holsten", "Thüringen"};

		var workdayslist = WorkDaysList.GetWorkDays();

		WorkDaysViewList.ItemsSource = workdayslist.ToList();
	}

    private void federalStatePicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}