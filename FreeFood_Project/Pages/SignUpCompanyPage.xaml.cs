using FreeFood_Project.ViewModel;

namespace FreeFood_Project.Pages;

public partial class SignUpCompanyPage : ContentPage
{
	public SignUpCompanyPage(SignUpViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}