using FreeFood_Project.ViewModel;

namespace FreeFood_Project;

public partial class App : Application
{
	public static GlobalDataViewModel globalDataApp;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		
		globalDataApp = new GlobalDataViewModel();
	}
}
