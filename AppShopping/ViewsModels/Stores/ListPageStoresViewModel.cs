using AppShopping.Models;
using AppShopping.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Stores
{
    public partial class ListPageStoresViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Estabilishment> estabilishmentsFull;

        [ObservableProperty]
        private List<Estabilishment> estabilishmentsFiltered;

        public ListPageStoresViewModel()
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
            estabilishmentsFull = service.GetAllStores();
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
