using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(50, ErrorMessage = "Name should contain 50 charachters maximum.")]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }

        [Precision(18, 2)]
        public decimal Bonus { get; set; }
        [Precision(18, 2)]
        public decimal Salary { get; set; }
        [Column("Hour_Rate"), Precision(18, 2)]
        public decimal HourRate { get; set; }
        [Column("Dep_Id")]
        public int DepartmentId { get; set; }

    }
}
