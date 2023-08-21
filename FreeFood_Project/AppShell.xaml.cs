using FreeFood_Project.CompanyPages;
using FreeFood_Project.Pages;
using FreeFood_Project.UserPages;
using System.Reflection;

namespace FreeFood_Project;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SignInUserPage), typeof(SignInUserPage));
		Routing.RegisterRoute(nameof(SignInCompanyPage), typeof(SignInCompanyPage));
		Routing.RegisterRoute(nameof(SignUpUserPage), typeof(SignUpUserPage));
		Routing.RegisterRoute(nameof(SignUpCompanyPage), typeof(SignUpCompanyPage));


        Routing.RegisterRoute(nameof(MainUserPage), typeof(MainUserPage));
        Routing.RegisterRoute(nameof(FavouritesUserPage), typeof(FavouritesUserPage));
        Routing.RegisterRoute(nameof(ProfileUserPage), typeof(ProfileUserPage));

        Routing.RegisterRoute(nameof(SettingsUserPage), typeof(SettingsUserPage));
        Routing.RegisterRoute($"{nameof(MainUserPage)}/{nameof(DetailBoxesPage)}", typeof(DetailBoxesPage));

        Routing.RegisterRoute($"{nameof(MainUserPage)}/{nameof(DetailCompanyPage)}", typeof(DetailCompanyPage));

        Routing.RegisterRoute($"{nameof(MainUserPage)}/{nameof(AllBoxesPage)}", typeof(AllBoxesPage));

        Routing.RegisterRoute($"{nameof(MainUserPage)}/{nameof(AllCompanyPage)}", typeof(AllCompanyPage));

        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

        Routing.RegisterRoute($"{nameof(PropertiesCompanyPage)}/{nameof(AddBoxPage)}", typeof(AddBoxPage));

        Routing.RegisterRoute($"{nameof(MainCompanyPage)}/{nameof(DetailBoxCompanyPage)}", typeof(DetailBoxCompanyPage));

        Routing.RegisterRoute($"{nameof(MainCompanyPage)}/{nameof(DetailBoxCompanyPage)}/{nameof(UpdateBoxPage)}", typeof(UpdateBoxPage));
    }

}
