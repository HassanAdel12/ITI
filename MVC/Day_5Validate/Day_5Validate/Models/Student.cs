using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5Validate.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

    }
}