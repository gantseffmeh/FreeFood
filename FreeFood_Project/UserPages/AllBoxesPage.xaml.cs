using FreeFood_Project.ViewModel;

namespace FreeFood_Project.UserPages;

public partial class AllBoxesPage : ContentPage
{
	public AllBoxesPage(AllBoxesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}