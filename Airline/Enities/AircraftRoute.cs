using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    [Table("Aircraft_Routes")]
    [PrimaryKey(nameof(AircraftId), nameof(RouteId), nameof(Departure))]
    internal class AircraftRoute
    {
        [Column("AC_Id")]
        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }
        [Column("Route_Id")]
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        public DateTime Departure { get; set; }
        
        [Column("Num_Pf_Pass")]
        public int NumberOfPassengers { get; set; }
        
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }
        public int Duration { get; set; }

    }
}
