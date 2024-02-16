using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using FreeFood_Project.CompanyPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Box", "Box")]
public partial class DetailBoxCompanyViewModel : ObservableObject
{
    [ObservableProperty]
    Box box;

    [RelayCommand]
    async Task  DeleteBox()
    {
        string id = Box.Id;
        Guid guid = new(id);
        JsonContent content = JsonContent.Create(guid);
        var response = await App.globalDataApp.HttpClient.DeleteAsync($"http://87.239.106.199:61742/api/Company/Bag?bagId={guid}");

        int status = (int)response.StatusCode;
        if (status == 200)
        {
            await Shell.Current.DisplayAlert("Успех", "Бокс удален!", "Ok");
            await Shell.Current.GoToAsync("..");
        }
        else
        {
            await Shell.Current.DisplayAlert("Ошибка", "Что-то пошло не так.", "Ok");
        }
        
    }

    [RelayCommand]
    async Task GoToUpdateBoxPage()
    {
        await Shell.Current.GoToAsync($"{nameof(UpdateBoxPage)}",
            new Dictionary<string, object>
            {
                {"Box", Box}
            });
    }

}
