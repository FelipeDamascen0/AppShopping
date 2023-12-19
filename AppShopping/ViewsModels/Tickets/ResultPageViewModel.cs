using AppShopping.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.ViewsModels.Tickets
{
    [QueryProperty(nameof(TicketParam), "ticketResult")]
    public partial class ResultPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Ticket ticketParam;

    }
}
