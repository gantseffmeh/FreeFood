using CommunityToolkit.Mvvm.ComponentModel;
using FreeFood_Project.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Companies", "Companies")]
public partial class AllCompanyViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<CompanyCard> companies;
}
