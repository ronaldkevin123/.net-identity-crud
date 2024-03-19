using System;

namespace _net_identity_crud.API.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public int Qty { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
