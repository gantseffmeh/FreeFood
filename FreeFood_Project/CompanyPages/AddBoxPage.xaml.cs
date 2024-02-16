using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class AddBoxPage : ContentPage
{
	public AddBoxPage(AddBoxViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}