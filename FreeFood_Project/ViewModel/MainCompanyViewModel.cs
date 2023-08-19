using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using FreeFood_Project.CompanyPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class MainCompanyViewModel : ObservableObject
{
    //[ObservableProperty]
    public ObservableCollection<Box> Boxes { get; } = new();

    [ObservableProperty]
    bool isRefreshing;

    public MainCompanyViewModel()
    {   
        Boxes.Clear();
        GetBoxes().Await();
    }

    [RelayCommand]
    async Task GetBoxes()
    {
        try
        {

            var response = await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/api/Company/GetBag", null);
                                                                

            List<Box> boxesList;
            if (response.IsSuccessStatusCode)
            {
                string json_c = await response.Content.ReadAsStringAsync();

                boxesList = JsonConvert.DeserializeObject<List<Box>>(json_c);

                if (Boxes.Count != 0)
                    Boxes.Clear();

                foreach (var box in boxesList)
                    Boxes.Add(box);
            }
        }catch(Exception ex)
        {
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsRefreshing = false;
        }
    }

    public class Box_Detail
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        /// <summary>
        /// Первое изображение в списке - превью
        /// </summary>
        public List<string>? ImagesId { get; set; }

        [Required]
        public uint Count { get; set; } = 0;

        [Required]
        public double Cost { get; set; } = 0;

        public bool IsFavorite { get; set; }

        public UInt64 NumberOfViews { get; set; }
    }

    [RelayCommand]
    async Task GoToDetailBoxCompanyPage(Box box)
    {
        string id = box.Id;
        Guid guid = new(id);
        JsonContent content = JsonContent.Create(guid);
        var response = await App.globalDataApp.HttpClient.PostAsync($"http://87.239.106.199:61742/api/Company/GetBag", content);

        string json_c = await response.Content.ReadAsStringAsync();

        var box_d = JsonConvert.DeserializeObject<List<Box_Detail>>(json_c);

        box.Description = box_d[0].Description;

        if (box is null)
        {
            return;
        }

        await Shell.Current.GoToAsync($"{nameof(DetailBoxCompanyPage)}",
            new Dictionary<string, object>
            {
                {"Box", box}
            });
    }
}

public static class TaskExtensions
{
    public async static void Await(this Task task)
    {
        await task;
    }
}