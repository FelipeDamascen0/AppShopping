using AppShopping.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Tickets
{
    public partial class ScanPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string ticketNumber;

        [RelayCommand]
        private void Scan()
        {
            Shell.Current.GoToAsync("pay");
        }

        [RelayCommand]
        private void List() 
        {
            Shell.Current.GoToAsync("list");
        }

        [RelayCommand]
        private void CheckTicketNumber() 
        { 
            if(TicketNumber?.Length < 15)
            {
                return;
            }

            var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
            var ticket = service.GetTicket(TicketNumber);

            if (ticket == null)
            {
                App.Current.MainPage.DisplayAlert("Ticket não encontrado", $"Não foi localizado um ticket com o numero {TicketNumber}", "OK");
                return;
            }
            if(TicketNumber.Length >= 12)
            {
                App.Current.MainPage.DisplayAlert("O numero do ticket excedeu o limite de caracteres","O numero do ticket ultrapassou o limite", "OK");
            }
            TicketNumber = string.Empty;

            var param = new Dictionary<string, object>
            {
                { "ticketParam", ticket }
            };

            Shell.Current.GoToAsync("pay", param);
        }
    }
}
