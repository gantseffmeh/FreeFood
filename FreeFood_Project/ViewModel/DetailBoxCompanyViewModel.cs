using CommunityToolkit.Mvvm.ComponentModel;
using FreeFood_Project.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Box", "Box")]
public partial class DetailBoxCompanyViewModel : ObservableObject
{
    [ObservableProperty]
    Box box;
}
