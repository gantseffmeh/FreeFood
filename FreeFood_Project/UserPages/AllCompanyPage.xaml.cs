using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class AllCompanyPage : ContentPage
{
	public AllCompanyPage(AllCompanyViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}