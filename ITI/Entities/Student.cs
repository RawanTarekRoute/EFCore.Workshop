using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{

    // POCO Class => Plain Old CLR Object , Doesn't contain any business logic
    internal class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required") , MaxLength(50 , ErrorMessage = "First name should contain 50 charachters maximum.")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last Name is required"), MaxLength(50, ErrorMessage = "Last name should contain 50 charachters maximum.")]
        public string LName { get; set; }

        [Range(12 , 23)]
        public int Age { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [Column("Dep_Id")]
        public int DepartmentId { get; set; }
    }
}
