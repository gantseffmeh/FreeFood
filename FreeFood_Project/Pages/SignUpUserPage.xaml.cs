using FreeFood_Project.ViewModel;

namespace FreeFood_Project.Pages;

public partial class SignUpUserPage : ContentPage
{
	public SignUpUserPage(SignUpViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}