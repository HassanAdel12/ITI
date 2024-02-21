using Day_5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5.ViweModel
{
    public class CountryLanguageModel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        [Display(Name = "Country")]
        public string CountryCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Language { get; set; }

        [Display(Name = "Is Official")]
        public bool IsOfficial { get; set; }

        [Range(0, 100)]
        public double Percentage { get; set; }

        public virtual Country Country { get; set; }
    }
}