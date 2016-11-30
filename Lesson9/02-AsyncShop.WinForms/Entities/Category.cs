namespace _02_AsyncShop.WinForms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }
    }
}
