using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day_7.Models;

public partial class Student
{
    public int Id { get; set; }

    [Display(Name = "Full Name")]
    public string FullName { get; set; } = null!;

    [Display(Name = "City Name")]
    public int CityId { get; set; }

    public bool Graduated { get; set; }
    
    [Range(2,4)]
    public decimal Gpa { get; set; }

    public virtual City? City { get; set; } 
}
