using FourthProject_Chart.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FourthProject_Chart.DataDB
{
    public class FourthProject_Chart_DBContext : IdentityDbContext<IdentityUser>
    {
        public FourthProject_Chart_DBContext(DbContextOptions<FourthProject_Chart_DBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<P0007_Placing_Plan_Head> P0007PlacingPlanHead { get; set; }
        public DbSet<P0008_Compaction> P0008Compaction { get; set; }
    }
}
