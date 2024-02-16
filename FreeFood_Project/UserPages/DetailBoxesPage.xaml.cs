using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class DetailBoxesPage : ContentPage
{
	public DetailBoxesPage(DetailBoxesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}