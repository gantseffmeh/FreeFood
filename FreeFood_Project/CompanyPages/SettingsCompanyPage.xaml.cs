using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class SettingsCompanyPage : ContentPage
{
	public SettingsCompanyPage(SettingCompanyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}