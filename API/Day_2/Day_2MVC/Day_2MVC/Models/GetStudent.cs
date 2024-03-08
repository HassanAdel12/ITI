using System.ComponentModel.DataAnnotations;

namespace Day_2MVC.Models
{
    public class GetStudent
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public bool Graduated { get; set; }

        [Range(2, 4)]
        public decimal Gpa { get; set; }

        public int CityId { get; set; }

    }
}
