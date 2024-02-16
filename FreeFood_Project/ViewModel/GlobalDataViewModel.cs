using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FreeFood_Project.ViewModel;

public partial class GlobalDataViewModel : ObservableObject
{

    [ObservableProperty]
    public string user_id;

    [ObservableProperty]
    public HttpClient httpClient;

    public GlobalDataViewModel() 
    {

    }

}
