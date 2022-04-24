using DrippyzOnlineStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrippyzOnlineStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BrandNames> BrandNames { get; set; }

        public DbSet<SpecialTag> SpecialTag { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}