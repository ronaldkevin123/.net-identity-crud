using System;

namespace _net_identity_crud.Data.Model
{
    public class Token
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
