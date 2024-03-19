using System;
using Microsoft.AspNetCore.Identity;

namespace _net_identity_crud.Data.Model
{
    public class AppUser: IdentityUser
    {
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
