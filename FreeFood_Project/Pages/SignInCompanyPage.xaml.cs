using FreeFood_Project.ViewModel;

namespace FreeFood_Project.Pages;

public partial class SignInCompanyPage : ContentPage
{
	public SignInCompanyPage(SignInViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}	