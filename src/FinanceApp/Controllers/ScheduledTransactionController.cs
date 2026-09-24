using FinanceApp.DTOs.ScheduledTransaction;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("scheduledtransaction")]
    public class ScheduledTransactionController(IScheduledTransactionService service) : ControllerBase
    {
        private readonly IScheduledTransactionService _service = service;

        [HttpPost()]
        public async Task<IActionResult> PostScheduledTransaction([FromBody]ScheduledTransactionRegisterDto dto)
        {
            var result = await _service.CreateAsync(dto);

            if (result is null)
                return BadRequest("Scheduled Transaction was not created");

            return CreatedAtAction(nameof(GetScheduledTransaction), new { id =  result.Id, userId = result.UserId}, result);
        }

        [HttpGet("{id}/{userId}")]
        public async Task<IActionResult> GetScheduledTransaction(string id, string userId)
        {
            var result = await _service.GetByIdAsync(id, userId);

            if (result is null)
                return NotFound("Scheduled Transaction was not found");

            return Ok(result);
        }

        [HttpDelete("{id}/{userId}")]
        public async Task<IActionResult> DeleteScheduledTransaction(string id, string userId)
        {
            var result = await _service.DeleteAsync(id, userId);

            if (!result)
                return NotFound("Scheduled Transaction was not found");

            return NoContent();
        }

        [HttpPatch("{id}/{userId}")]
        public async Task<IActionResult> UpdateScheduledTransaction(string id, string userId, [FromBody]ScheduledTransactionUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, userId, dto);

            if (result is null)
                return NotFound("Scheduled Transaction was not found");

            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            var result = await _service.GetByUserIdAsync(userId);

            if (!result.Any())
                return NotFound("No Scheduled Transaction was found");

            return Ok(result);
        }
    }
}
