using FreeFood_Project.ViewModel;

namespace FreeFood_Project.Pages;

public partial class SignInUserPage : ContentPage
{
	public SignInUserPage(SignInViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

   
}