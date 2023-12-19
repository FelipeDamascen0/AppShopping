using AppShopping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.Models
{
    public class Estabilishment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Localization { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public EstablishmentType Type { get; set; }
        public string Cover { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
    }
}
