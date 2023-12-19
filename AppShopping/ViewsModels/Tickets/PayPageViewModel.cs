using AppShopping.Models;
using AppShopping.Storages;
using AppShopping.Views.Tickets;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Tickets
{
    [QueryProperty(nameof(TicketParam), "ticketParam")]
    public partial class PayPageViewModel : ObservableObject
    {
        
        private Ticket ticketParam;

        public Ticket TicketParam 
        { 
            get { return ticketParam; }
            set
            {
                GenerateDateOut(value);
                GeneratePrice(value);
                SetProperty(ref ticketParam, value);
            } 
        }

        [ObservableProperty]
        private string pixCode = "https://github.com/FelipeDamascen0";

        [RelayCommand]
        private async void CopyAndPaste()
        {
            await App.Current.MainPage.DisplaySnackbar("Texto copiado com sucesso", null, "OK", TimeSpan.FromSeconds(2000));
            await Clipboard.Default.SetTextAsync(PixCode);
            await Task.Delay(30000);

            var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();
            storage.Save(TicketParam);

            var param = new Dictionary<string, object>
            {
                { "ticketResult", TicketParam }
            };
            await Shell.Current.GoToAsync("../result", param);

        }
        private void GenerateDateOut(Ticket ticket)
        {
            var rd = new Random();
            var hour = rd.Next(0, 12);
            var minute = rd.Next(0,60);

            ticket.DateOut = ticket.DateIn.AddHours(hour).AddMinutes(minute);
            ticket.DataTolerance = ticket.DateOut.AddMinutes(30);
        }

        private double HourValue = 0.10;
        private void GeneratePrice(Ticket ticket)
        {
            var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
            var difTS = new TimeSpan(dif);
            ticket.Price = difTS.TotalMinutes * HourValue;
        }
    }
}
