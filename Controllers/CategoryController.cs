using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using Supermarket.Domain.Services;
using Supermarket.Domain.Models;
using Supermarket.Resources;
using Supermarket.Extensions;

using AutoMapper;

namespace Supermarket.Controllers
{
    [Route("/api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryService;
        private readonly IMapper mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            this.CategoryService = categoryService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await this.CategoryService.ListAsync();
            var resources = this.mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = this.mapper.Map<SaveCategoryResource, Category>(resource);
            var result = await this.CategoryService.SaveAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = this.mapper.Map<Category, CategoryResource>(result.Category);
            return Ok(categoryResource);
        }
    }
}