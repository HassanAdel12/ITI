using System.ComponentModel.DataAnnotations;

namespace Day_9.Models
{
    public class Student
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string FullName { get; set; }

        [Range(2,4)]
        public float GPA { get; set; }

        public bool Graduated { get; set; }


    }
}
