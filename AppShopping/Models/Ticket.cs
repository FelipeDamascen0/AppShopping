using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; } = string.Empty;
        public DateTimeOffset DateIn { get; set; }
        public DateTimeOffset DateOut { get; set; }
        public DateTimeOffset DataTolerance { get; set; }
        public double Price { get; set; }
    }
}
