namespace MauiApp1;

public partial class ProjectsPage : ContentPage
{
	string text = "";
	public ProjectsPage()
	{
		InitializeComponent();

		var projview = ProjectsList.GetPojects();

		ProjectsView.ItemsSource = projview;


	}

   
}