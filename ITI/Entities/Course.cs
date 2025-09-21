using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(50, ErrorMessage = "Name should contain 50 charachters maximum.")]
        public string Name { get; set; }
        public int Duration { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Column("Top_Id")]
        public int TopicId { get; set; }
    }
}
