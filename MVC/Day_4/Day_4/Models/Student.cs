namespace Day_4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50),MinLength(3)]
        public string FullName { get; set; }

        public int CityID { get; set; }

        public bool Graduated { get; set; }
        [Range(2.0, 4.00)]
        public decimal GPA { get; set; }

        public virtual City City { get; set; }
    }
}
