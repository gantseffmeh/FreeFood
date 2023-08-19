using FreeFood_Project.ViewModel;

namespace FreeFood_Project;

public partial class App : Application
{
	public static GlobalDataViewModel globalDataApp;
	public static string main_url = "http://87.239.106.199:61742";
									

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		
		globalDataApp = new GlobalDataViewModel();
	}
}
