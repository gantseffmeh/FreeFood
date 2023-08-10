using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class SignUpViewModel : ObservableObject
{
    [RelayCommand]
    async Task GoToSignInPage(string type)
    {

        //await Shell.Current.GoToAsync($"{nameof(SignInUserPage)}");
        switch (type)
        {
            case "user":
                await Shell.Current.GoToAsync($"..");
                break;
            case "company":
                await Shell.Current.GoToAsync($"..");
                break;
        }
    }
}
