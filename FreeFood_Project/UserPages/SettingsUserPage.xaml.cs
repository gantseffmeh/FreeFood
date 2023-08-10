using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class SettingsUserPage : ContentPage
{
	public SettingsUserPage(SettingsUserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}