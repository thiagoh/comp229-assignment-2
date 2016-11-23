namespace comp229_assignment_2.Models {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RestaurantContext : DbContext {
        // 
        // If you wish to target a different database and/or database provider, modify the 'RestaurantContext' 
        // connection string in the application configuration file.
        public RestaurantContext()
            : base("name=RestaurantContext") {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder) {

            //modelBuilder.Entity<Dish>()
            //            .HasRequired(m => m.team1)
            //            .WithMany(t => t.HomeMatches)
            //            .HasForeignKey(m => m.team1Id)
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Game>()
            //            .HasRequired(m => m.GuestTeam)
            //            .WithMany(t => t.AwayMatches)
            //            .HasForeignKey(m => m.GuestTeamId)
            //            .WillCascadeOnDelete(false);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}