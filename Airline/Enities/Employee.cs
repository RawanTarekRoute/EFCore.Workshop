using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        [Column("BD_Year")]
        public int BirthDayYear { get; set; }
        [Column("BD_Month")]
        public int BirthDayMonth { get; set; }
        [Column("BD_Day")]
        public int BirthDayDay { get; set; }
        [Column("AL_Id")]
        public int AirlineId { get; set; }
    }
}
