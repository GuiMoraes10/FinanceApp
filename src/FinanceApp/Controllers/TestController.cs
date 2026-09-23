using FinanceApp.Configuration;
using FinanceApp.Models;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController(IUserService userService) : ControllerBase
    {
        IUserService _userService = userService;

        [HttpPost("user")]
        public async Task<IActionResult> TestRequisition([FromBody] string name)
        {
            var result = await _userService.CreateNewUserAsync(name);

            return Ok(result);
        }

        [HttpGet("cosmos")]
        public async Task<IActionResult> TestCosmos(
        [FromServices] CosmosDbConfiguration cosmos)
        {
            var database = cosmos.Database;

            var databaseResponse = await database.ReadAsync();

            var containerResponse = await cosmos.Users.ReadContainerAsync();

            return Ok(new
            {
                Database = databaseResponse.Resource.Id,
                Container = containerResponse.Resource.Id
            });
        }
    }
}
