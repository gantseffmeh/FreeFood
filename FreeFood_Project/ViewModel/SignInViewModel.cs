using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Pages;
using FreeFood_Project.UserPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;


public partial class SignInViewModel : ObservableObject
{

    [ObservableProperty]
    string login;

    [ObservableProperty]
    string password;


    [RelayCommand]
    async Task GoToSignUpPage(string type)
    {
        switch (type)
        {
            case "user":
                await Shell.Current.GoToAsync($"{nameof(SignUpUserPage)}");
                break;
            case "company":
                await Shell.Current.GoToAsync($"{nameof(SignUpCompanyPage)}");
                break;
        }
    }

    [RelayCommand]
    async void SignIn(string type)
    {
        if(Password == "123")
        {
            await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}?user_id=123");
            App.globalDataApp.User_id = $"{Login}";
            return;
        }
    }
}
