using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2API.Model
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
        
        [ForeignKey("City")]
        public int CityId { get; set; }

        public virtual City City { get; set; }

    }
}
