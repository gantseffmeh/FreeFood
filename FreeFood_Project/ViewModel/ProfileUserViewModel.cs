using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.UserPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class ProfileUserViewModel : ObservableObject
{
    [ObservableProperty]
    string user_id;


    public ProfileUserViewModel()
    {
        user_id = App.globalDataApp.User_id;
    }

    [RelayCommand]
    async Task GoToSettingsUserPage()
    {
        await Shell.Current.GoToAsync($"{nameof(SettingsUserPage)}");
    }


    [RelayCommand]
    async Task GoToAboutPage()
    {
        await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
    }
}
