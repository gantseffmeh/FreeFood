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

public partial class AddBoxViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string description;

    [ObservableProperty]
    int count;

    [ObservableProperty]
    int cost;

    class Box_
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public List<string>? ImagesId { get; set; }
    }

    [RelayCommand]
    async Task AddBox()
    {
        Box_ box = new Box_ { Name = Name, Description = Description, Cost = Cost, Count = Count, ImagesId = new()  };

        JsonContent content = JsonContent.Create(box);

        try
        {
            var response = await App.globalDataApp.HttpClient.PutAsync($"http://87.239.106.199:61742/api/Company/Bag", content);
            //HttpClient httpClient = new HttpClient();

            string json = await response.Content.ReadAsStringAsync();

            //var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            var status = (int)response.StatusCode;

            if (status == 200)
            {
                await Shell.Current.DisplayAlert("Успех", "Бокс успешно добавлен", "Ok");
                await Shell.Current.GoToAsync($"..");
                Name = "";
                Description = "";
                Cost = 0;
                Count = 0;
            }
            else
            {
                await Shell.Current.DisplayAlert("Провал", "Что-то пошло не так. Повторите попытку.", "Ok");
            }
        }
        catch(Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
        }
      
        
        
    }
}
