using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Airline.Enities
{
    internal class Route
    {
        public int Id { get; set; }
        [Precision(18, 2), Required]
        public decimal Distance { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string Origin { get; set; }
        public string Classification { get; set; }
    }
}
