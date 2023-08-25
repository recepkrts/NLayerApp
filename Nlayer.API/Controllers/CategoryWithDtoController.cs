using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entity;
using NLayer.Core.Services;

namespace Nlayer.API.Controllers
{
    public class CategoryWithDtoController : CustomBaseController
    {
        private readonly IServiceWithDto<Category, CategoryDto> _serviceWithDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> serviceWithDto)
        {
            _serviceWithDto = serviceWithDto;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return CreateActionResult(await _serviceWithDto.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Get(CategoryDto categoryDto)
        {
            return CreateActionResult(await _serviceWithDto.AddAsync(categoryDto));
        }
    }
}
