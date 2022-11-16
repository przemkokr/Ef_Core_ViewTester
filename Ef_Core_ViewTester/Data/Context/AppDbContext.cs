using Ef_Core_ViewTester.Data.Models;
using Ef_Core_ViewTester.Data.ReadModels;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_ViewTester.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Item> Items { get; set; } = default!;

        public DbSet<ItemDescription> ItemDescriptions { get; set; } = default!;

        public DbSet<Car> Cars { get; set; } = default!;

        public DbSet<ItemReadModel> ItemReadModels { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemReadModel>().ToView("ItemReadModels");
        }
        
    }
}
