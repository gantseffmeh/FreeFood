using CommunityToolkit.Mvvm.ComponentModel;
using FreeFood_Project.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;


public partial class FavouritesViewModel : ObservableObject
{
    [ObservableProperty]
    string user_id;

    [ObservableProperty]
    public ObservableCollection<BoxCard> boxes;

    public FavouritesViewModel() 
    {
        Boxes = new ObservableCollection<BoxCard>
        {
            new BoxCard{Name="Весёлый бокс",Describe="Лучшие продукты", Price="200р."},
            new BoxCard{Name="Грустный бокс",Describe="Более менее продукты", Price="450р."},
            new BoxCard{Name="На хайпе бокс",Describe="Продукты из Магнита", Price="300р."},
        };
    }
}
