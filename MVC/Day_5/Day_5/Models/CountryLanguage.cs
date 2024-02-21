namespace Day_5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryLanguage")]
    public partial class CountryLanguage
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CountryCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Language { get; set; }

        public bool IsOfficial { get; set; }

        public double Percentage { get; set; }

        public virtual Country Country { get; set; }
    }
}
