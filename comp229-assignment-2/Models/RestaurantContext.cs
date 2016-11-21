namespace comp229_assignment_2.Models {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext {
        public RestaurantContext()
            : base("name=RestaurantContext") {
        }

        public virtual DbSet<Dish> Dishes { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Album>()
        //        .Property(e => e.Price)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Artist>()
        //        .HasMany(e => e.Albums)
        //        .WithRequired(e => e.Artist)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Genre>()
        //        .HasMany(e => e.Albums)
        //        .WithRequired(e => e.Genre)
        //        .WillCascadeOnDelete(false);
        //}
    }
}
