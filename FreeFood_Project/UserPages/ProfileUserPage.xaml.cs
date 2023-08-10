using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class ProfileUserPage : ContentPage
{
	public ProfileUserPage(ProfileUserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}