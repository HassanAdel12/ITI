namespace Day_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Employee No")]
        public int EmpNo { get; set; }

        [Display(Name = "Department No")]
        public int? DeptNo { get; set; }

        public int? Salary { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Frist name")]
        public string EmpFname { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Last name")]
        public string EmpLname { get; set; }

        public virtual Department Department { get; set; }
    }
}
