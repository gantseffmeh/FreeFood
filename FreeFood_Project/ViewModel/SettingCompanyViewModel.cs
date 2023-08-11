using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class SettingCompanyViewModel : ObservableObject
{
    [RelayCommand]
    async Task LogOut()
    {

        await Shell.Current.GoToAsync($"//{nameof(ChooseTypeUserPage)}");
        Application.Current.MainPage = new AppShell();
    }
}
