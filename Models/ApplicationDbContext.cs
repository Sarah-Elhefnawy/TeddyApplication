using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TeddyApplication.Models;

namespace TeddyApplication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    //public DbSet<AuthModel> Auth { get; set; }
    //public DbSet<RefreshToken> RefreshTokenn { get; set; }
    //public DbSet<RegisterModel> RegisterModel { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            Database.EnsureCreated();
    }
}
}
