using Business.Abstracts;
using Business.Dtos.Requests.Categories;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)                           
        {
            _categoryService = categoryService;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)  
        {
            var result = await _categoryService.Add(createCategoryRequest);
            return Ok(result);
        }


        [HttpGet("Getlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _categoryService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] Category category)
        {
            var result = await _categoryService.Update(category);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] Category category)
        {
            var result = await _categoryService.Delete(category);
            return Ok(result);
        }


    }
}
