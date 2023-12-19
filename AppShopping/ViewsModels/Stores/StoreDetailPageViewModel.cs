using AppShopping.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Stores
{
    [QueryProperty(nameof(Estabilishment), "establishment")]
    public partial class StoreDetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Estabilishment estabilishment;

        [RelayCommand]
        private async void BackListStorePage()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
