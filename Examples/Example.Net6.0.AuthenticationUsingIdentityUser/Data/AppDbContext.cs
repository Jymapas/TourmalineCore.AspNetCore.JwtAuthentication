using Example.Net6._0.AuthenticationUsingIdentityUser.Models;
using Microsoft.EntityFrameworkCore;
using TourmalineCore.AspNetCore.JwtAuthentication.Identity;

namespace Example.Net6._0.AuthenticationUsingIdentityUser.Data
{
    public class AppDbContext : TourmalineDbContext<CustomUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}