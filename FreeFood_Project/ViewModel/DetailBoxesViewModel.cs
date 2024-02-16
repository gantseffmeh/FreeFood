using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Box", "Box")]
public partial class DetailBoxesViewModel : ObservableObject
{
    [ObservableProperty]
    BoxCard box;

    [RelayCommand]
    async void AddFavorites(string type)
    {
        string Id = "";
        JsonContent content = JsonContent.Create(Id);

        var response_u = await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/api/User/Bag/Favorites", content);
        //HttpClient httpClient = new HttpClient();

        string json_u = await response_u.Content.ReadAsStringAsync();

        var values_u = JsonConvert.DeserializeObject<Dictionary<string, string>>(json_u);

        //var status_ = (int)response_u.StatusCode;

    }
}
