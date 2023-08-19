using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFood_Project.Cards;
using FreeFood_Project.CompanyPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood_Project.ViewModel;

public partial class PropertiesCompanyViewModel : ObservableObject
{
    
    [RelayCommand]
    async Task GoToAddBoxPage()
    {
        await Shell.Current.GoToAsync($"{nameof(AddBoxPage)}");
    }
}
