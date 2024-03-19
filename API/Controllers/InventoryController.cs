using System;
using _net_identity_crud.API.DTOs;
using _net_identity_crud.API.Mapper;
using _net_identity_crud.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _net_identity_crud.API.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InventoryController : BaseController
    {
        private readonly IProductRepo _productRepo;
        public InventoryController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IActionResult> GetAllProducts()
        {
            var state = await _productRepo.GetAllAsync();

            if(state is null)
            {
                return NoContent();
            }
            else
            {
                return Ok(state);
            }
        }

        [HttpGet]
        [Route("item={product_id:guid}")]
        public async Task<IActionResult> GetProductById([FromRoute] Guid product_id)
        {
            var state = await _productRepo.GetProductByIdAsync(product_id);

            if(state is null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(state.ToProductDto());
            }
        }

        [HttpPost]
        [Route("item_create")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var state = createProductDto.ToProductFromCreateDto();

            await _productRepo.CreateAsync(state);

            return CreatedAtAction(nameof(GetProductById), 
                                    new{product_id = state.Id},
                                    state.ToProductDto());
        }

        [HttpPatch]
        [Route("item_update={product_id:guid}")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] Guid product_id,
            [FromBody] UpdateProductDto updateProduct)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var state = await _productRepo.UpdateAsync(product_id, updateProduct);

            if(state is null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(state.ToProductDto());
            }
        }

        [HttpDelete]
        [Route("item_remove={product_id:guid}")]
        public async Task<IActionResult> DeleteProduct(Guid product_id)
        {
            var state = await _productRepo.DeleteAsync(product_id);

            if(state is null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok("Delete Success!");
            }
        }

    }
}
