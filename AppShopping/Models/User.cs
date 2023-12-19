using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? AcessCode { get; set; }
        public DateTimeOffset? AcessCodeValid { get; set; }
    }
}
