using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class DetailBoxCompanyPage : ContentPage
{
	public DetailBoxCompanyPage(DetailBoxCompanyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}