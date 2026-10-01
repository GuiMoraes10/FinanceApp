using FinanceApp.DTOs.Transaction;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("transaction")]
    public class TransactionController(ITransactionService service) : ControllerBase
    {
        private readonly ITransactionService _service = service;

        [HttpGet("{id}/{userId}")]
        public async Task<IActionResult> GetTransaction(string id, string userId)
        {
            var result = await _service.GetByIdAsync(id, userId);

            if (result is null)
                return NotFound("Transaction was not found");

            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            var result = await _service.GetByUserIdAsync(userId);

            if (!result.Any())
                return NotFound("Transaction was not found");

            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> PostTransaction([FromBody] TransactionRegisterDto dto)
        {
            try
            {
                if (dto.Value <= 0)
                    return BadRequest("Transaction must be positive");

                var result = await _service.CreateAsync(dto);

                return CreatedAtAction(nameof(GetTransaction), new { id = result.Id, userId = result.UserId }, result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}/{userId}")]
        public async Task<IActionResult> DeleteTransaction(string id, string userId)
        {
            try
            {
                bool result = await _service.DeleteAsync(id, userId);

                if (!result)
                    return NotFound("Transaction was not found");

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/{userId}")]
        public async Task<IActionResult> UpdateTransaction(string id, string userId, [FromBody] TransactionUpdateDto dto)
        {
            try
            {
                var result = await _service.UpdateAsync(id, userId, dto);

                if (result is null)
                    return NotFound("Transaction was not found");

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
