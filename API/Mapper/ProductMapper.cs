using System;
using _net_identity_crud.API.DTOs;
using _net_identity_crud.Data.Model;

namespace _net_identity_crud.API.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToProductDto(this Product productModel)
        {
            return new ProductDto
            {
                Id = productModel.Id,
                ProductName = productModel.ProductName,
                Detail = productModel.Detail,
                Qty = productModel.Qty,
                Remarks = productModel.Remarks,
                Status = productModel.Status
            };
        }

        // Create Product
        public static Product ToProductFromCreateDto(this CreateProductDto productDto)
        {
            return new Product
            {
                ProductName = productDto.ProductName,
                Detail = productDto.Detail,
                Qty = productDto.Qty,
                Remarks = productDto.Remarks
            };
        }

        // Update Product
        public static Product ToProductFromUpdateDto(this UpdateProductDto updateProductDto)
        {
            return new Product
            {
                ProductName = updateProductDto.ProductName,
                Detail = updateProductDto.Detail,
                Qty = updateProductDto.Qty,
                Remarks = updateProductDto.Remarks,
                Status = updateProductDto.Status
            };
        }
    }
}
