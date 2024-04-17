using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RebecaBarrezueta1004WebApplication1.Models
{
    public class Burguer
    {
        public int BurguerId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
}
