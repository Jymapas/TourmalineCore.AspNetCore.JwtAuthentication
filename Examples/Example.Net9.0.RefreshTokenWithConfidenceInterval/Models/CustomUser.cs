using Microsoft.AspNetCore.Identity;

namespace Example.Net9._0.RefreshTokenWithConfidenceInterval.Models;

public class CustomUser : IdentityUser
{
    public string Name { get; set; }
}