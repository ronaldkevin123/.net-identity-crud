using System;
using System.ComponentModel.DataAnnotations;

namespace _net_identity_crud.Data.Model
{
    public class Login
    {
        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
