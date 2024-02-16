using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Box", "Box")]
public partial class UpdateBoxCompanyViewModel : ObservableObject
{
    [ObservableProperty]
    Box box;

    //[ObservableProperty]
    //string name;

    //[ObservableProperty]
    //string description;

    //[ObservableProperty]
    //int cost;

    //[ObservableProperty]
    //int count;

    //[ObservableProperty]
    //string idImage;


    [RelayCommand]
    async Task UpdateBox()
    {
        JsonContent content = JsonContent.Create(Box);
        var response = await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/api/Company/Bag", content);

        int status = (int)response.StatusCode;

        if (status == 200)
        {
            await Shell.Current.DisplayAlert("Успех", "Бокс изменен", "Ok");
            await Shell.Current.GoToAsync($"../..");
        }
        else
        {
            await Shell.Current.DisplayAlert("Провал", "Что-то пошло не так. Повторите попытку", "Ok");

        }
    }
}
