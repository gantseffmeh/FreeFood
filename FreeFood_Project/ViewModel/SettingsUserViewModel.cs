using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Model;
using FreeFood_Project.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class SettingsUserViewModel : ObservableObject
{

    [ObservableProperty]
    string user_id;

    [ObservableProperty]
    User user;

    public SettingsUserViewModel()
    {
        user_id = App.globalDataApp.User_id;

        User = new User { Name = "Max", Email = $"{User_id}", Number = "7988848412", Location = "г.Уфа" };
    }

    [RelayCommand]
    async Task LogOut()
    {
        await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/api/User/Logout", null);
        await Shell.Current.GoToAsync($"//{nameof(ChooseTypeUserPage)}");
        Application.Current.MainPage = new AppShell();
    }
}
