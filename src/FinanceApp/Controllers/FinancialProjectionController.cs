using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("financialProjection")]
    public class FinancialProjectionController(IFinancialProjectionService projectionService) : ControllerBase
    {
        private readonly IFinancialProjectionService _projectionService = projectionService;

        [HttpGet("{userId}/monthlyBalance")]
        public async Task<IActionResult> GetMonthlyBalance(string userId)
        {
            try
            {
                var result = await _projectionService.GetMonthlyBalance(userId);

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{userId}/monthlyScheduledExpenses")]
        public async Task<IActionResult> GetMonthlyScheduledExpenses(string userId)
        {
            var result = await _projectionService.GetMonthlyScheduledExpenses(userId);

            return Ok(result);
        }

        [HttpGet("{userId}/monthlyScheduledIncomes")]
        public async Task<IActionResult> GetMonthlyScheduledIncomes(string userId)
        {
            var result = await _projectionService.GetMonthlyScheduledIncomes(userId);

            return Ok(result);
        }

        [HttpGet("{userId}/yearlyInvestmentsProjection")]
        public async Task<IActionResult> GetYearlyInvestmentsProjection(string userId)
        {
            try
            {
                var result = await _projectionService.GetUserInvestmentsProjection(userId);

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{userId}/yearlyRelatory")]
        public async Task<IActionResult> GetYearlyRelatory(string userId)
        {
            try
            {
                var result = await _projectionService.GetYearlyRelatory(userId);

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
