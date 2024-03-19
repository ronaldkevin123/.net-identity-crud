using System;
using System.ComponentModel.DataAnnotations;

namespace _net_identity_crud.API.DTOs
{
    public class UpdateProductDto
    {
        [Required]
        public string ProductName { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        [Required]
        public int Qty { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
