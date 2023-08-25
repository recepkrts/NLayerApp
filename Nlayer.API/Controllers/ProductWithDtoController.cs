using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nlayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entity;
using NLayer.Core.Services;

namespace Nlayer.API.Controllers
{
    public class ProductWithDtoController : CustomBaseController
    {
        private readonly IProductsServiceWithDto _productsServiceWithDto;

        public ProductWithDtoController(IProductsServiceWithDto productsServiceWithDto)
        {
            _productsServiceWithDto = productsServiceWithDto;
        }

        //Get api/products/GetProdcutWithCategory
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProdcutWithCategory()
        {
            return CreateActionResult(await _productsServiceWithDto.GetProductsWithCategort());
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _productsServiceWithDto.GetAllAsync());
        }

        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _productsServiceWithDto.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductCreateDto productCreatedDto)
        {
            return CreateActionResult(await _productsServiceWithDto.AddAsync(productCreatedDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            return CreateActionResult(await _productsServiceWithDto.UpdateAsync(productUpdateDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _productsServiceWithDto.RemoveAsync(id));
        }

        [HttpPost("SaveAll")]
        public async Task<IActionResult> Save(List<ProductDto> productDtos)
        {
            return CreateActionResult(await _productsServiceWithDto.AddRangeAsync(productDtos));
        }

        [HttpDelete("RemoveAll")]
        public async Task<IActionResult> RemoveAll(List<int> ids)
        {
            return CreateActionResult(await _productsServiceWithDto.RemoveRangeAsync(ids));
        }

        [HttpDelete("Any/{id}")]
        public async Task<IActionResult> Any(int id)
        {
            return CreateActionResult(await _productsServiceWithDto.AnyAsync(x=>x.Id==id));
        }
    }
}
