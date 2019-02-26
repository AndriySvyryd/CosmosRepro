using Microsoft.EntityFrameworkCore;

namespace CosmosRepro
{
    public class CosmosContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "https://localhost:8081",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                "CosmosRepro");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class1>(eb =>
            {
                eb.OwnsOne(e => e.SubObj);
            });

            modelBuilder.Entity<Class2>(eb =>
            {
                eb.OwnsOne(e => e.SubObj);
            });
        }
    }
}
