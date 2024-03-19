using System;
using _net_identity_crud.API.DTOs;
using _net_identity_crud.Data.DbContext;
using _net_identity_crud.Data.Model;
using _net_identity_crud.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace _net_identity_crud.Services.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product productModel)
        {
            await _context.Product.AddAsync(productModel);
            await _context.SaveChangesAsync();

            return productModel;
        }

        public async Task<Product?> DeleteAsync(Guid id)
        {
            var state = await _context.Product.FirstOrDefaultAsync(data => data.Id == id);

            if(state is null)
            {
                return null;
            }
            else
            {
                _context.Product.Remove(state);

                await _context.SaveChangesAsync();

                return state;
            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _context.Product.FirstOrDefaultAsync(data => data.Id == id);
        }

        public async Task<Product?> UpdateAsync(Guid id, UpdateProductDto updateProduct)
        {
            var state = await _context.Product.FirstOrDefaultAsync(data => data.Id == id);

            if(state is null)
            {
                return null;
            }
            else
            {
                state.ProductName = updateProduct.ProductName;
                state.Detail = updateProduct.Detail;
                state.Qty = updateProduct.Qty;
                state.Remarks = updateProduct.Remarks;
                state.Status = updateProduct.Status;

                await _context.SaveChangesAsync();

                return state;
            }
        }
    }
}
