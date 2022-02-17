namespace MauiApp1;

public partial class MonthlyTasksPage : ContentPage
{
	int count = 0;
	public MonthlyTasksPage()
	{
		InitializeComponent();


		ProjPicker.ItemsSource = ProjectsList.GetPojects().Select(p => p.Title).ToList();
		dailyTasksView.ItemsSource = DailyWorkList.GetDailyWorkList();

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		
    }

   
}