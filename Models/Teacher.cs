using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [Range(22, 70)]
        public int TeacherAge { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string TeacherName { get; set; }
     

    }
}
