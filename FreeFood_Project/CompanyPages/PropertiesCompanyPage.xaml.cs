using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class PropertiesCompanyPage : ContentPage
{
	public PropertiesCompanyPage(PropertiesCompanyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}