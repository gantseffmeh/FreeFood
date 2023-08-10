using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeFood_Project.Pages;
namespace FreeFood_Project.ViewModel;

public partial class MainViewModel : ObservableObject
{



    [RelayCommand]
    async Task GoToSignInPage(string type)
    {
        
        //await Shell.Current.GoToAsync($"{nameof(SignInUserPage)}");
        switch (type)
        {
            case "user":
                await Shell.Current.GoToAsync($"{nameof(SignInUserPage)}");
                break;
            case "company":
                await Shell.Current.GoToAsync($"{nameof(SignInCompanyPage)}");
                break;
        }
    }

    
}
