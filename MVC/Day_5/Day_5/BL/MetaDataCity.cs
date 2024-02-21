using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5.BL
{
    public class MetaDataCity
    {
        [Display(Name = "City Code")]
        public string ID { get; set; }
        
        [Display(Name = "City Name")]
        public string Name { get; set; }

        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }

        [Range(100,1000000)]
        public int Population { get; set; }
    }
}