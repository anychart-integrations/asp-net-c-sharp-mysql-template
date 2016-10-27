namespace AspNetCSharpMysqlTemplate
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class FruitDBContext : DbContext
    {
        public FruitDBContext()
            : base("name=FruitDBContext")
        {
        }

        public virtual DbSet<fruit> fruits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<fruit>()
                .Property(e => e.name)
                .IsUnicode(false);
        }

        public List<fruit> topFruits()
        {
            return fruits.OrderByDescending(item => item.value).Take(5).ToList();
        }
    }
}
