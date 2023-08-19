using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.CompanyPages;
using FreeFood_Project.Pages;
using FreeFood_Project.UserPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;


public partial class SignInViewModel : ObservableObject
{

    public class LoginViewModel
    {

        public string Email { get; set; } = null!;


        public string Password { get; set; } = null!;


    }

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
        //if(Password == "123")
        //{
        //    await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}?user_id=123");
        //    App.globalDataApp.User_id = $"{Login}";
        //    return;
        //}


        LoginViewModel Login_in = new();
        App.globalDataApp.User_id = $"{Login}";

        App.globalDataApp.HttpClient = new HttpClient();

        Login_in.Email = Login;
        Login_in.Password = Password;
        JsonContent content = JsonContent.Create(Login_in);

        //var response = await App.globalDataApp.HttpClient.PostAsync($"{App.main_url}/api/Company/Login", content);
        ////HttpClient httpClient = new HttpClient();

        //string json = await response.Content.ReadAsStringAsync();

        //var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        //if (values["succeeded"] == "true")
        //{
        switch (type)
            {
                case "user":
                var response_u = await App.globalDataApp.HttpClient.PostAsync($"{App.main_url}/api/User/Login", content);
                //HttpClient httpClient = new HttpClient();

                //string json_u = await response_u.Content.ReadAsStringAsync();

                //var values_u = JsonConvert.DeserializeObject<Dictionary<string, string>>(json_u);

                var status_ = (int)response_u.StatusCode;

                if (status_ == 200)
                {
                    await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}");
                    App.globalDataApp.User_id = $"{Login}";
                }
                else
                {
                    await Shell.Current.DisplayAlert("Ошибка авторизации", "Неправильный логин или пароль", "Ok");
                }
                break;
                case "company":
                    var response_c= await App.globalDataApp.HttpClient.PostAsync($"{App.main_url}/api/Company/Login", content);
                //HttpClient httpClient = new HttpClient();

                //string json_c = await response_c.Content.ReadAsStringAsync();

                //var values_c = JsonConvert.DeserializeObject<Dictionary<string, string>>(json_c);

                var status = (int)response_c.StatusCode;
                if (status == 200)
                {
                    await Shell.Current.GoToAsync($"//{nameof(MainCompanyPage)}");
                    App.globalDataApp.User_id = $"{Login}";
                }
                else
                {
                    await Shell.Current.DisplayAlert("Ошибка авторизации", "Неправильный логин или пароль", "Ok");
                }
                break;
            }
            Login = "";
            Password = "";
        //}
        //else
        //{
        //    await Shell.Current.DisplayAlert("Ошибка авторизации", "Неправильный логин или пароль", "Ok");
        //}
        
        
    }
}

    //public partial class SignInViewModel : ObservableObject
//{

//    [ObservableProperty]
//    string login;

//    [ObservableProperty]
//    string password;

//    public class LoginViewModel
//    {
//        [Required]
//        [DataType(DataType.EmailAddress)]
//        public string Email { get; set; } = null!;

//        [Required]
//        [DataType(DataType.Password)]
//        public string Password { get; set; } = null!;


//    }

//    [RelayCommand]
//    async Task GoToSignUpPage(string type)
//    {
//        switch (type)
//        {
//            case "user":
//                await Shell.Current.GoToAsync($"{nameof(SignUpUserPage)}");
//                break;
//            case "company":
//                await Shell.Current.GoToAsync($"{nameof(SignUpCompanyPage)}");
//                break;
//        }
//    }

//    [RelayCommand]
//    async void SignIn(string type)
//    {
//        //if(Password == "123")
//        //{
//        //    await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}?user_id=123");
//        //    App.globalDataApp.User_id = $"{Login}";
//        //    return;
//        //}

//        LoginViewModel Login = new();
//        Login.Email = login;
//        Login.Password = password;

//        switch (type)
//        {
//            case "user":
//                {
//                    await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}");
//                    App.globalDataApp.User_id = $"{Login}";

//                    HttpClient httpClient = new HttpClient();

//                    JsonContent content = JsonContent.Create(Login);
//                    // устанавливаем заголовок 
//                    content.Headers.Add("SecreteCode", "Anything");

//                    using var response = await httpClient.PostAsync("http://localhost:49825/api/Identity/Login", content);
//                    string responseText = await response.Content.ReadAsStringAsync();
//                    Console.WriteLine(responseText);
//                    break;
//                }

//            case "company":
//                await Shell.Current.GoToAsync($"//{nameof(MainCompanyPage)}");
//                App.globalDataApp.User_id = $"{Login}";
//                break;
//        }
//    }
//}
