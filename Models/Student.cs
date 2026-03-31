using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int StudentId { get; set; }
        [Range(5, 18)]
        public int StudentAge { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string StudentName { get; set;}
        public bool isActive { get; set; }

    }
}
