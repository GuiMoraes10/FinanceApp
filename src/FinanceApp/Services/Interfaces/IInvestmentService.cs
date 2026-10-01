using FinanceApp.DTOs.Investment;
using FinanceApp.Entities;

namespace FinanceApp.Services.Interfaces
{
    public interface IInvestmentService
    {
        public Task<Investment> CreateAsync(InvestmentRegisterDto dto);
        public Task<Investment?> GetByIdAsync(string id, string userid);
        public Task<Investment?> UpdateAsync(string id, string userId, InvestmentUpdateDto dto);
        public Task<Investment?> WithdrawAsync(string id, string userId, decimal value);
        public Task<Investment?> DepositAsync(string id, string userId, decimal value);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<IEnumerable<Investment>> GetByUserIdAsync(string userId);
    }
}
