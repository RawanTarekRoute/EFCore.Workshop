using System.ComponentModel.DataAnnotations;

namespace ITI.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(50, ErrorMessage = "Name should contain 50 charachters maximum.")]
        public string Name { get; set; }
    }
}
