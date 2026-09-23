using FinanceApp.Configuration;
using FinanceApp.DTOs;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController(IUserService userService) : ControllerBase
    {
        IUserService _userService = userService;

        [HttpPost()]
        public async Task<IActionResult> TestRequisition([FromBody] UserRegisterDto dto)
        {
            var result = await _userService.CreateNewUser(dto);

            return Ok(result);
        }
    }
}
