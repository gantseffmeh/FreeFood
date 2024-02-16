using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;



public partial class MainUserPage : ContentPage
{

	public MainUserPage(MainUserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	
	}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        Uri uri = new Uri("https://www.microsoft.com");
    //        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    //    }
    //    catch (Exception ex)
    //    {
    //        // An unexpected error occurred. No browser may be installed on the device.
    //    }
    //}
}