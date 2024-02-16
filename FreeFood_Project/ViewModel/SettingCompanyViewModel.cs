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
        
        await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/index.html/api/Company/Logout", null);
        //await Shell.Current.GoToAsync($"//{nameof(ChooseTypeUserPage)}");
        Application.Current.MainPage = new AppShell();
        
    }
}
