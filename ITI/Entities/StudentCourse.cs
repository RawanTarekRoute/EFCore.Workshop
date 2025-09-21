using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{
    [Table("Stud_Course")]
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
   
    internal class StudentCourse
    {
        [Column("Stud_Id")]
        public int StudentId { get; set; }
        [Column("Course_Id")]
        public int CourseId { get; set; }
        public decimal Grade { get; set; }
    }
}
