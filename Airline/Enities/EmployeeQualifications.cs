using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airline.Enities
{
    [Table("Emp_Qualifications")]
    [PrimaryKey(nameof(EmployeeId), nameof(Qualification))]
    internal class EmployeeQualifications
    {
        [Column("Emp_Id")]
        public int EmployeeId { get; set; }
        public string Qualification { get; set; }
    }
}
