using Clearforge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clearforge.Infrastructure.Data
{
    public class ClearforgeDbContext : DbContext
    {
        public ClearforgeDbContext(DbContextOptions<ClearforgeDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasMany(u => u.Licenses).WithOne(l => l.User).HasForeignKey(l => l.UserId);
            modelBuilder.Entity<User>().HasMany(u => u.Devices).WithOne(d => d.User).HasForeignKey(d => d.UserId);
            modelBuilder.Entity<User>().HasMany(u => u.Subscriptions).WithOne(s => s.User).HasForeignKey(s => s.UserId);
        }
    }
}
