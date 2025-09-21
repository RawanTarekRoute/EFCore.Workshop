using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    [Table("Airline_Phones")]
    [PrimaryKey(nameof(AirlineId), nameof(Phone))]
    internal class AirlinePhones
    {
        [Column("AL_Id")]
        public int AirlineId { get; set; }
        public int Phone { get; set; }
    }
}
