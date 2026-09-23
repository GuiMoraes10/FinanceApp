using FinanceApp.Configuration;
using FinanceApp.Models;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("test")]
    public class UserController(IUserService userService) : ControllerBase
    {
        IUserService _userService = userService;

        [HttpPost("user")]
        public async Task<IActionResult> TestRequisition([FromBody] string name)
        {
            var result = await _userService.CreateNewUserAsync(name);

            return Ok(result);
        }
    }
}
