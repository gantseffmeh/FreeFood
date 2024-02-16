using CommunityToolkit.Mvvm.ComponentModel;
using FreeFood_Project.Cards;
using FreeFood_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

[QueryProperty("Company", "Company")]
public partial class DetailCompanyViewModel : ObservableObject
{
    [ObservableProperty]
    Company company;
}
