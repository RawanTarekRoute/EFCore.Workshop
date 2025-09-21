using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    internal class Transaction
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        [Column("AL_Id")]
        public int AirlineId { get; set; }


    }
}
