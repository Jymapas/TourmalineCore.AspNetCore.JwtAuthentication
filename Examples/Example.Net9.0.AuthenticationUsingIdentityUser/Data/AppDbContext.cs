using Example.Net9._0.AuthenticationUsingIdentityUser.Models;
using Microsoft.EntityFrameworkCore;
using TourmalineCore.AspNetCore.JwtAuthentication.Identity;

namespace Example.Net9._0.AuthenticationUsingIdentityUser.Data
{
    public class AppDbContext : TourmalineDbContext<CustomUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}