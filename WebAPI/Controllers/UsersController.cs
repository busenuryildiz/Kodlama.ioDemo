using Business.Abstracts;
using Business.Dtos.Requests.Users;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserRequest createUserRequest)
        {
            var result = await _userService.Add(createUserRequest);
            return Ok(result);
        }


        [HttpGet("Getlist")]
        public async Task<IActionResult> GetList()
        {
            var result = await _userService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _userService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] User user)
        {
            var result = await _userService.Update(user);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] User user)
        {
            var result = await _userService.Delete(user);
            return Ok(result);
        }
    }
}
