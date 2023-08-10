using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;



public partial class MainUserPage : ContentPage
{

	public MainUserPage(MainUserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	
	}
}