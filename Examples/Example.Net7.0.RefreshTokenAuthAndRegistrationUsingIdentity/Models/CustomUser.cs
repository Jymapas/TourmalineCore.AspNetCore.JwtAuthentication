using Microsoft.AspNetCore.Identity;

namespace Example.Net7._0.RefreshTokenAuthAndRegistrationUsingIdentity.Models;

public class CustomUser : IdentityUser
{
    public string Name { get; set; }
}