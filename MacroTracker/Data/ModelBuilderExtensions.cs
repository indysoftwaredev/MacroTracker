using MacroTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace MacroTracker.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Unit>().HasData(
                new Unit { Id = 1, Name = "Gram" });
            modelBuilder.Entity<Models.Unit>().HasData(
                new Unit() { Id = 2, Name = "Ounce" });
            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 3, Name = "Each" });
            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 4, Name = "Tablespoon" });
            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 5, Name = "Teaspoon" });
        }
    }
}
