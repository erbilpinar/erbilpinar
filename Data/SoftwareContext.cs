using Microsoft.EntityFrameworkCore;
using MyWebsite.Models;

namespace MyWebsite.Data
{
    public class SoftwareContext : DbContext
    {
        public SoftwareContext (DbContextOptions<SoftwareContext> options)
            : base(options)
        {
        }

        public DbSet<Software> Software { get; set; }
    }
}