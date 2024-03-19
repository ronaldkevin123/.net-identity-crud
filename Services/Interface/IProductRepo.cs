using System;
using _net_identity_crud.API.DTOs;
using _net_identity_crud.Data.Model;

namespace _net_identity_crud.Services.Interface
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetProductByIdAsync(Guid id);
        Task<Product> CreateAsync(Product productModel);
        Task<Product?> UpdateAsync(Guid id, UpdateProductDto updateProduct);
        Task<Product?> DeleteAsync(Guid id);
    }
}
