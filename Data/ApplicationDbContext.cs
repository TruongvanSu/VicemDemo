using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VicemMVCIdentity.Models;
using VicemMVCIdentity.Models.Entities;

namespace VicemMVCIdentity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employee { get; set; } = default!;
    public DbSet<MemberUnit> MemberUnit { get; set; } = default!;
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    //     builder.Entity<ApplicationUser>().ToTable("Users");
    //     builder.Entity<IdentityRole>().ToTable("Roles");
    //     builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
    //     builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
    //     builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
    //     builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
    //     builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
    //     builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
    // }
}
