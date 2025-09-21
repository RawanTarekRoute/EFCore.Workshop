using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{
    [Table("Course_Instructor")]
    [PrimaryKey (nameof(CourseId), nameof(InstructorId))]

    internal class CourseInstructor
    {
        [Column("Course_Id")]
        public int CourseId { get; set; }
        [Column("Inst_Id")]
        public int InstructorId { get; set; }

        [Precision(18, 2)]
        public decimal Evaluation { get; set; }
    }
}
