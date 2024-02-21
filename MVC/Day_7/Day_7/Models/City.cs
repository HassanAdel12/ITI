using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day_7.Models;

public partial class City
{
    public int Id { get; set; }

    [Display(Name = "City")]
    public string Name { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
