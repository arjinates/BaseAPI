using Microsoft.EntityFrameworkCore;
using SoftwareLab.Core.Entities;

namespace SoftwareLab.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasKey(t => t.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
