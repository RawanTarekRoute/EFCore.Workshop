using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Airline.Enities
{

    internal class Aircraft
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
        public Crew Crew { get; set; }
        public int AirlineId { get; set; } // by convention it will be considered as FK
        public virtual Airline Airline { get; set; }
        public virtual ICollection<AircraftRoute> AircraftRoutes { get; set; }

    }
}
