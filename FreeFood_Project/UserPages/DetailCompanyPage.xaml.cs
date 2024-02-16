using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class DetailCompanyPage : ContentPage
{
	public DetailCompanyPage(DetailCompanyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}