using System;

namespace _net_identity_crud.Data.Model
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public int Qty { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
