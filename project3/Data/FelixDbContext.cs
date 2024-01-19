
using Microsoft.EntityFrameworkCore;
using project3.Models;

namespace project3.Data
{
    public class FelixDbContext : DbContext
    {
        public FelixDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<user> Users { get; set; } = null!;
        public virtual DbSet<company> Companies { get; set; } = null!;
        public virtual DbSet<job> Jobs { get; set; } = null!;
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;

    }
}
