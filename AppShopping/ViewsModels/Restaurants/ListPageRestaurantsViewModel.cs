using AppShopping.Models;
using AppShopping.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Restaurants
{
    public partial class ListPageRestaurantsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Estabilishment> estabilishmentsFull;

        [ObservableProperty]
        private List<Estabilishment> estabilishmentsFiltered;

        public ListPageRestaurantsViewModel()
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<RestaurantsService>();
            estabilishmentsFull = service.GetAllRestaurants();
            estabilishmentsFiltered = estabilishmentsFull.ToList();
        }

        [RelayCommand]
        private void TextSearchInList()
        {
            EstabilishmentsFiltered = estabilishmentsFull.Where(s => s.Name.ToLower().Contains(TextSearch.ToLower())).ToList();
        }

        [RelayCommand]
        private async void TapEstablishmentGoToDetailPage(Estabilishment establishment)
        {
            var navigationParameter = new Dictionary<string, object>()
            {
                { "establishment", establishment }
            };
            await Shell.Current.GoToAsync("detail", navigationParameter);
        }
    }
}
