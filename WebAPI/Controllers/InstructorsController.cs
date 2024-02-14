using Business.Abstracts;
using Business.Dtos.Requests.Instructors;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            var result = await _instructorService.Add(createInstructorRequest);
            return Ok(result);
        }


        [HttpGet("Getlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _instructorService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] Instructor instructor)
        {
            var result = await _instructorService.Update(instructor);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] Instructor instructor)
        {
            var result = await _instructorService.Delete(instructor);
            return Ok(result);
        }
    }
}
