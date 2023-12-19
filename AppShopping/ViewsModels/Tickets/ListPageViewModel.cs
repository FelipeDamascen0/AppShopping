using AppShopping.Models;
using AppShopping.Storages;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Tickets
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Ticket> tickets;

        public ListPageViewModel()
        {
            var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();
            Tickets = storage.Load();
        }
    }
}
