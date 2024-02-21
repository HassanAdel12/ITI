namespace Day_5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Cities = new HashSet<City>();
            CountryLanguages = new HashSet<CountryLanguage>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(52)]
        [Display(Name = "Country")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Continent { get; set; }

        [Required]
        [StringLength(26)]
        public string Region { get; set; }

        public double SurfaceArea { get; set; }

        public short? IndepYear { get; set; }

        public int Population { get; set; }

        public double? LifeExpectancy { get; set; }

        public double? GNP { get; set; }

        public double? GNPOld { get; set; }

        [Required]
        [StringLength(45)]
        public string LocalName { get; set; }

        [Required]
        [StringLength(45)]
        public string GovernmentForm { get; set; }

        [StringLength(60)]
        public string HeadOfState { get; set; }

        public int? Capital { get; set; }

        [Required]
        [StringLength(2)]
        public string Code2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryLanguage> CountryLanguages { get; set; }
    }
}
