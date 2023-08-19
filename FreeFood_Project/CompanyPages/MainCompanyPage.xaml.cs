using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class MainCompanyPage : ContentPage
{
	public MainCompanyPage(MainCompanyViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
		
	}
}