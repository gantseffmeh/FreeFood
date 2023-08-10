using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using FreeFood_Project.UserPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("User_id", "user_id")]
public partial class MainUserViewModel : ObservableObject
{
    [ObservableProperty]
    string user_id;

    [ObservableProperty]
    public ObservableCollection<CompanyCard> companies;
    //public GlobalDataViewModel globalData;

    [ObservableProperty]
    public ObservableCollection<BoxCard> boxes;

    public MainUserViewModel()
    {
        Companies = new ObservableCollection<CompanyCard> {
            new CompanyCard{Name = "КФС", Address="г.Уфа"},
            new CompanyCard{Name = "Вкусно и точка", Address="г.Уфа"},
            new CompanyCard{Name = "Бургер Кинг", Address="г.Уфа"},
            new CompanyCard{Name = "Мастер и Маргарита", Address="г.Уфа"},
            new CompanyCard{Name = "Шахта Бургер", Address="г.Уфа"},
       };

        Boxes = new ObservableCollection<BoxCard>
        {
            new BoxCard{Name="Весёлый бокс",Describe="Лучшие продукты", Price="200р."},
            new BoxCard{Name="Грустный бокс",Describe="Более менее продукты", Price="450р."},
            new BoxCard{Name="На хайпе бокс",Describe="Продукты из Магнита", Price="300р."},
            new BoxCard{Name="Нормальный бокс",Describe="Продукты из магазинов", Price="150р."}
        };
    }

    [RelayCommand]
    async Task GoToDetailBoxes(BoxCard box)
    {
        if(box is null)
        {
            return;
        }

        await Shell.Current.GoToAsync($"{nameof(DetailBoxesPage)}",
            new Dictionary<string, object>
            {
                {"Box", box}
            });
    }

    [RelayCommand]
    async Task GoToDetailCompany(CompanyCard company)
    {
        if (company is null)
        {
            return;
        }

        await Shell.Current.GoToAsync($"{nameof(DetailCompanyPage)}",
            new Dictionary<string, object>
            {
                {"Company", company}
            });
    }
}


