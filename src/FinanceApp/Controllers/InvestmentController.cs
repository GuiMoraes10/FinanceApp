using FinanceApp.DTOs.Investment;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("investment")]
    public class InvestmentController(IInvestmentService service) : ControllerBase
    {
        private readonly IInvestmentService _service = service;

        [HttpPost()]
        public async Task<IActionResult> PostInvestment([FromBody] InvestmentRegisterDto dto)
        {
            var result = await _service.CreateAsync(dto);

            if (result is null)
                return BadRequest("Investment was not created");

            return CreatedAtAction(nameof(GetInvestment), new { id = result.Id, userId = result.UserId }, result);
        }

        [HttpGet("{id}/{userId}")]
        public async Task<IActionResult> GetInvestment(string id, string userId)
        {
            var result = await _service.GetByIdAsync(id, userId);

            if (result is null)
                return NotFound("Investment was not found");

            return Ok(result);
        }

        [HttpDelete("{id}/{userId}")]
        public async Task<IActionResult> DeleteInvestment(string id, string userId)
        {
            var result = await _service.DeleteAsync(id, userId);

            if (!result)
                return NotFound("Investment was not found");

            return NoContent();
        }

        [HttpPatch("{id}/{userId}")]
        public async Task<IActionResult> UpdateInvestment(string id, string userId, [FromBody] InvestmentUpdateDto dto)
        {
            var result = await _service.UpdateAsync(id, userId, dto);

            if (result is null)
                return NotFound("Investment was not found");

            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            var result = await _service.GetByUserIdAsync(userId);

            if (!result.Any())
                return NotFound("Investment was not found");

            return Ok(result);
        }

        [HttpPatch("{id}/{userId}/balancewithdraw")]
        public async Task<IActionResult> WithdrawBalance(string id, string userId, [FromBody] decimal value)
        {
            try
            {
                if (value <= 0)
                    return BadRequest("Value must be positive");

                var result = await _service.WithdrawAsync(id, userId, value);

                if (result is null)
                    return NotFound("Investment was not found");

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/{userId}/balancedeposit")]
        public async Task<IActionResult> DepositBalance(string id, string userId, [FromBody] decimal value)
        {
            if (value <= 0)
                return BadRequest("Value must be positive");

            var result = await _service.DepositAsync(id, userId, value);

            if (result is null)
                return NotFound("Investment was not found");

            return Ok(result);
        }
    }
}
