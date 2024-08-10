using HRSample.Models;
using Microsoft.EntityFrameworkCore;

namespace HRSample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Salaries> Salaries { get; set; }
    }
}
