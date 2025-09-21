using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{
    internal class Department
    {
        public int Id { get; set; } // By Convention, it will be mapped to the PK

        [Required, MaxLength(60)]
        public string Name { get; set; }

        [Column("Hiring_Date")]
        public DateOnly HiringDate { get; set; }

        [Column("Ins_Id")]
        public int InstructorId { get; set; }
    }
}
