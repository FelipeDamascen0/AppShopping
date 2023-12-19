using AppShopping.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Restaurants
{
    [QueryProperty(nameof(Estabilishment), "establishment")]
    public partial class RestaurantDetailPage : ObservableObject
    {
        [ObservableProperty]
        private Estabilishment estabilishment;

        [RelayCommand]
        private async void BackListRestaurantPage()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
