using Business.Abstracts;
using Business.Dtos.Requests.Courses;
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
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            var result = await _courseService.Add(createCourseRequest);
            return Ok(result);
        }


        [HttpGet("Getlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _courseService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] Course course)
        {
            var result = await _courseService.Update(course);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] Course course)
        {
            var result = await _courseService.Delete(course);
            return Ok(result);
        }

    }

}
