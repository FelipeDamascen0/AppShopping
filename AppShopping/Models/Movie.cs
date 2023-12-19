using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TimeOnly Duration { get; set; }
        public string Cover { get; set; } = string.Empty;
        public string Trailer { get; set; } = string.Empty;
    }
}
