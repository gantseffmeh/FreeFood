using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class FavouritesUserPage : ContentPage
{
	public FavouritesUserPage(FavouritesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


}