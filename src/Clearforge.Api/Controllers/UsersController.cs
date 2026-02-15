using Clearforge.Application.Services;
using Clearforge.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Clearforge.Api.Controllers
{
    // DTOs for request bodies
    public class UserRegisterDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }

    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto model)
        {
            try
            {
                var user = await _userService.RegisterAsync(model.Name, model.Email, model.Password);
                return Ok(new { message = "User registered successfully" });
            }
            catch (ApplicationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto model)
        {
            try
            {
                var token = await _userService.LoginAsync(model.Email, model.Password);
                return Ok(new { token });
            }
            catch (ApplicationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize] // This endpoint is now protected
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.GetUsersAsync();
        }
    }
}
