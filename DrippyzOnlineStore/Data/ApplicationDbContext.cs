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

        public DbSet<DrippyzOnlineStore.Models.BrandNames> BrandNames { get; set; }

        public DbSet<DrippyzOnlineStore.Models.SpecialTag> SpecialTag { get; set; }

        public DbSet<DrippyzOnlineStore.Models.Product> Products { get; set; }
    }
}