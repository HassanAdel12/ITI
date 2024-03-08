using System.ComponentModel.DataAnnotations;

namespace Day_1.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public bool Graduated { get; set; }

        [Range(2, 4)]
        public decimal Gpa { get; set; }
    }
}
