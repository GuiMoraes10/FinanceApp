using FinanceApp.Configuration;
using FinanceApp.DTOs.User;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost()]
        public async Task<IActionResult> PostUser([FromBody] UserRegisterDto dto)
        {
            var result = await _userService.CreateNewUser(dto);

            if (result is null)
                return BadRequest("User was not created");

            return CreatedAtAction(nameof(GetUser), new { id = result.Id }, result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var result = await _userService.GetUserById(id);

            if (result is null)
                return NotFound("User was not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var result = await _userService.DeleteUserAsync(id);

            if (!result)
                return NotFound("User was not found");

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] UserUpdateDto dto)
        {
            var result = await _userService.UpdateUser(id, dto);

            if (result is null)
                return NotFound("User was not found");

            return Ok(result);
        }

        [HttpPatch("{id}/balance")]
        public async Task<IActionResult> UpdateBalance(string id, [FromBody] decimal balance)
        {
            if (balance < 0)
                return BadRequest("Balance cannot be negative");

            var result = await _userService.SetUserBalance(id, balance);

            if (!result)
                return BadRequest("User balance was not updated");

            return NoContent();
        }

        [HttpPatch("{id}/password")]
        public async Task<IActionResult> UpdatePassword(string id, [FromBody][Required] string password)
        {
            var result = await _userService.SetUserPassword(id, password);

            if (!result)
                return NotFound("User was not found");

            return NoContent();
        }
    }
}
