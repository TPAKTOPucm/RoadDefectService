using Microsoft.EntityFrameworkCore;
using RoadDefectService.Models;

namespace RoadDefectService.Data
{
    public class RoadContext : DbContext
    {
        public RoadContext(DbContextOptions<RoadContext> options) : base(options)
        {}
        public DbSet<Defects> Defects { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defects>().HasKey(d => d.X);
            modelBuilder.Entity<Defects>().HasKey(d => d.Y);
            modelBuilder.Entity<Image>().HasKey(d => d.DefectsY);
            modelBuilder.Entity<Image>().HasKey(d => d.DefectsX);

        }
    }
}
