using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MileStoneProject.Models
{
    [Table("Students")]
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(255)]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }
    }
}