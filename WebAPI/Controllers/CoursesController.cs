using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;
        ICategoryService _categoryService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Course course)      
        {
            await _courseService.Add(course);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }


        [HttpGet("getcoursedetails")]
        public async Task<IActionResult> GetCourseDetails()
        {
            var result = await _courseService.GetDetailsListAsync();
            return Ok(result);
        }
    }

}
