namespace _02_AsyncShop.WinForms.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
