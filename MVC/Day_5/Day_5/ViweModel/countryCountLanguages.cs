using Day_5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5.ViweModel
{
    public class countryCountLanguages
    {
        [Key]
        [StringLength(3)]
        [Display(Name = "Country")]
        public string CountryName { get; set; }

        [Display(Name = "Count Languages Is Official")]
        public int LanguagesIsOfficial { get; set; }

 
        [Display(Name = "Count Languages Isn't Official")]
        public int LanguagesIsNotOfficial { get; set; }

    }
}