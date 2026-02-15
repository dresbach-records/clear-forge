using Clearforge.Application.Services;
using Clearforge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Clearforge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.GetUsersAsync();
        }
    }
}
