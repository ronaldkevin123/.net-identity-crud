using System;
using System.ComponentModel.DataAnnotations;

namespace _net_identity_crud.Data.Model
{
    public class Register
    {
        [Required]
        public required string Username { get; set; }

        [EmailAddress]
        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
