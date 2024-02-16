using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeFood_Project.Pages;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using FreeFood_Project.CompanyPages;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace FreeFood_Project.ViewModel;

public partial class MainViewModel : ObservableObject
{


    public MainViewModel() { }


    //public class BagInfoViewModel
    //{
    //    public Guid Id { get; set; }

    //    [Required]
    //    public string Name { get; set; } = null!;

    //    public string? Description { get; set; }

    //    /// <summary>
    //    /// Первое изображение в списке - превью
    //    /// </summary>
    //    public List<string>? ImagesId { get; set; }

    //    [Required]
    //    public uint Count { get; set; } = 0;

    //    [Required]
    //    public double Cost { get; set; } = 0;

    //}

    

    [RelayCommand]
    async Task GoToSignInPage(string type)
    {

        switch (type)
        {
            case "user":
                await Shell.Current.GoToAsync($"{nameof(SignInUserPage)}");
                break;
            case "company":
                await Shell.Current.GoToAsync($"{nameof(SignInCompanyPage)}");
                break;
        }
        //LoginViewModel Login = new();
        //Login.Email = "company@example.com";
        //Login.Password = "_Aa123456";


        ////await Shell.Current.GoToAsync($"{nameof(SignInUserPage)}");
        //switch (type)
        //{
        //    case "user":
        //        {
        //            //await Shell.Current.GoToAsync($"//{nameof(MainUserPage)}");
        //            App.globalDataApp.User_id = $"{Login}";

        //            HttpClient httpClient = new HttpClient();

        //            JsonContent content = JsonContent.Create(Login);
        //            // устанавливаем заголовок 
        //            //content.Headers.Add("SecreteCode", "Anything");

        //            try
        //            {

        //                var response = await httpClient.PostAsync("http://87.239.106.199:61742/api/Company/Login", content);

        //            }
        //            catch (Exception a)
        //            {
        //                Console.WriteLine($"Exception: {a.Message}");
        //            }

        //            try
        //            {
        //                using var response = await httpClient.GetAsync("http://87.239.106.199:61742/api/User/Profile");
        //                Console.WriteLine(await response.Content.ReadAsStringAsync());
        //            }
        //            catch (Exception a)
        //            {
        //                Console.WriteLine($"Exception: {a.Message}");

        //            }

        //            break;
        //        }

        //    case "company":
        //        await Shell.Current.GoToAsync($"//{nameof(MainCompanyPage)}");
        //        App.globalDataApp.User_id = $"{Login}";
        //        break;
        //}
    }

    
}
