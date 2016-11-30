namespace _02_AsyncShop.WinForms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manufacturer")]
    public partial class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(20)]
        public string ManufacturerName { get; set; }
    }
}
