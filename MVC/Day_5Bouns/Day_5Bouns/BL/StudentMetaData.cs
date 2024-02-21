using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5Bouns.BL
{
    public class StudentMetaData
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "City")]
        public int CityID { get; set; }

        [Range(2,4)]
        public decimal GPA { get; set; }
    }
}