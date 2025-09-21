using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    internal class Airline
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(50, ErrorMessage = "Name should contain 50 charachters maximum.")]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [Column("Cont_person")]
        public string ContactPerson { get; set; }
    }
}
