using CommunityToolkit.Mvvm.ComponentModel;
using FreeFood_Project.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class AllBoxesViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<BoxCard> boxes;


}
