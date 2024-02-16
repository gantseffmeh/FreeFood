using FreeFood_Project.ViewModel;

namespace FreeFood_Project.Pages;

public partial class ChooseTypeUserPage : ContentPage
{
	public ChooseTypeUserPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    
}