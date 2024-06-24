using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ST10263794_CLDV6211_POE_PART2.Data;

public class KhumaloCraftDbContextContext : IdentityDbContext<IdentityUser>
{
    public KhumaloCraftDbContextContext(DbContextOptions<KhumaloCraftDbContextContext> options)
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
}
