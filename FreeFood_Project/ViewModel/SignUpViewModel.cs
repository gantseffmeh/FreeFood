using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class SignUpViewModel : ObservableObject
{

    [ObservableProperty]
    string name_company;

    [ObservableProperty]
    string name;

    [ObservableProperty]
    string number;

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string password;

    [ObservableProperty]
    string passwordConfirm;

    public class SignUpUserModel
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }


    }

    public class SignUpCompanyModel
    {

        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }


    }


    [RelayCommand]
    async Task SignUp(string type)
    {
        switch (type)
        {
            case "user":
                SignUpUserModel userSignUp = new SignUpUserModel
                {
                    Name = Name,
                    Email = Email,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm
                };

                App.globalDataApp.HttpClient = new HttpClient();
                JsonContent content = JsonContent.Create(userSignUp);

                var response = await App.globalDataApp.HttpClient.PostAsync($"{App.main_url}/api/User/Registration", content);
                //HttpClient httpClient = new HttpClient();

                var status = (int)response.StatusCode;

                if (status == 200)
                {
                    await Shell.Current.DisplayAlert("Успех", "Регистрация прошла успешно", "Ok");
                    await Shell.Current.GoToAsync($"..");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Провал", "Что-то пошло не так. Повторите попытку", "Ok");

                }


                break;

            case "company":

                SignUpCompanyModel companySignUp = new SignUpCompanyModel
                {
                    Name = Name,
                    Email = Email,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm,
                    PhoneNumber=Number
                    
                };

                App.globalDataApp.HttpClient = new HttpClient();
                JsonContent content_ = JsonContent.Create(companySignUp);

                var response_ = await App.globalDataApp.HttpClient.PostAsync($"{App.main_url}/api/Company/Registration", content_);
                //HttpClient httpClient = new HttpClient();

                var status_ = (int)response_.StatusCode;

                if (status_ == 200)
                {
                    await Shell.Current.DisplayAlert("Успех", "Регистрация прошла успешно", "Ok");
                    await Shell.Current.GoToAsync($"..");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Провал", "Что-то пошло не так. Повторите попытку", "Ok");

                }
                break;
            default:
                break;
        }
    }

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