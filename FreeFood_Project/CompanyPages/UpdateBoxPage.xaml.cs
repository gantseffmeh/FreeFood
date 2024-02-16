using FreeFood_Project.ViewModel;

namespace FreeFood_Project.CompanyPages;

public partial class UpdateBoxPage : ContentPage
{
	public UpdateBoxPage(UpdateBoxCompanyViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}