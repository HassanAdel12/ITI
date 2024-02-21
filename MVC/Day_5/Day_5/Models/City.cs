namespace Day_5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    [MetadataType(typeof (Day_5.BL.MetaDataCity))]
    public partial class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(35)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryCode { get; set; }

        [Required]
        [StringLength(20)]
        public string District { get; set; }

        public int Population { get; set; }

        public virtual Country Country { get; set; }
    }
}
