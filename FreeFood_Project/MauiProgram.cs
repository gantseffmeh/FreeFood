﻿using FreeFood_Project.CompanyPages;
using FreeFood_Project.Pages;
using FreeFood_Project.UserPages;
using FreeFood_Project.ViewModel;
using Microsoft.Extensions.Logging;

namespace FreeFood_Project;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<ChooseTypeUserPage>();
		builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<SignInUserPage>();
        builder.Services.AddSingleton<SignInCompanyPage>();
        builder.Services.AddSingleton<SignInViewModel>();

        builder.Services.AddSingleton<SignUpUserPage>();
        builder.Services.AddSingleton<SignUpCompanyPage>();
        builder.Services.AddSingleton<SignUpViewModel>();

        builder.Services.AddSingleton<GlobalDataViewModel>();

        builder.Services.AddSingleton<MainUserPage>();
        builder.Services.AddSingleton<MainUserViewModel>();

		builder.Services.AddSingleton<ProfileUserPage>();
		builder.Services.AddSingleton<ProfileUserViewModel>();

        builder.Services.AddSingleton<FavouritesUserPage>();
        builder.Services.AddSingleton<FavouritesViewModel>();

        builder.Services.AddTransient<SettingsUserPage>();
        builder.Services.AddTransient<SettingsUserViewModel>();

        builder.Services.AddTransient<SettingsCompanyPage>();
        builder.Services.AddTransient<SettingCompanyViewModel>();

        builder.Services.AddSingleton<DetailBoxesPage>();
        builder.Services.AddSingleton<DetailBoxesViewModel>();

        builder.Services.AddSingleton<DetailCompanyPage>();
        builder.Services.AddSingleton<DetailCompanyViewModel>();

        builder.Services.AddSingleton<AllBoxesPage>();
        builder.Services.AddSingleton<AllBoxesViewModel>();

        builder.Services.AddSingleton<AllCompanyPage>();
        builder.Services.AddSingleton<AllCompanyViewModel>();

        builder.Services.AddSingleton<PropertiesCompanyPage>();
        builder.Services.AddSingleton<PropertiesCompanyViewModel>();

        builder.Services.AddSingleton<AddBoxPage>();
        builder.Services.AddSingleton<AddBoxViewModel>();

        builder.Services.AddTransient<MainCompanyPage>();
        builder.Services.AddTransient<MainCompanyViewModel>();

        builder.Services.AddSingleton<DetailBoxCompanyPage>();
        builder.Services.AddSingleton<DetailBoxCompanyViewModel>();


        builder.Services.AddSingleton<UpdateBoxPage>();
        builder.Services.AddSingleton<UpdateBoxCompanyViewModel>();

        return builder.Build();
	}
}
