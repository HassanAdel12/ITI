namespace Day_5Bouns.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    [MetadataType(typeof(BL.StudentMetaData))]
    public partial class Student 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int CityID { get; set; }

        public bool Graduated { get; set; }

        public decimal GPA { get; set; }

        public virtual City City { get; set; }
    }
}
