using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Model;
using FreeFood_Project.UserPages;
using Newtonsoft.Json;
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
    async void GoToSettingsUserPage()
    {
        var response = await App.globalDataApp.HttpClient.GetAsync($"http://87.239.106.199:61742/api/User/Profile");
        //HttpClient httpClient = new HttpClient();

        string json = await response.Content.ReadAsStringAsync();

        User_view user = JsonConvert.DeserializeObject<User_view>(json);

        //var status_ = (int)response_u.StatusCode;


        await Shell.Current.GoToAsync($"{nameof(SettingsUserPage)}?User_id={App.globalDataApp.User_id}",
            new Dictionary<string, object>
            {
                {"User", user }
            });
        return;
    }


    [RelayCommand]
    async Task GoToAboutPage()
    {
        await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
        
    }
}
