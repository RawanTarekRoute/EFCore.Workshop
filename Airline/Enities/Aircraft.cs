using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    internal class Aircraft
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
        [Column("Maj_pilot")]
        public string MajorPilot { get; set; }
        public string Assistant { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }
        [Column("AL_Id")]
        public int AirlineId { get; set; }
    }
}
