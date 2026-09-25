using FinanceApp.DTOs.Investment;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    public class InvestmentService(IInvestmentRepository repository) : IInvestmentService
    {
        private readonly IInvestmentRepository _repository = repository;

        public async Task<Investment> CreateAsync(InvestmentRegisterDto dto)
        {
            Investment investment = new Investment
            {
                UserId = dto.UserId,
                Name = dto.Name,
                Balance = dto.Balance,
                EstimatedPercent = dto.EstimatedPercent,
            };

            return await _repository.CreateAsync(investment);
        }

        public async Task<Investment?> GetByIdAsync(string id, string userId)
        {
            return await _repository.GetByIdAsync(id, userId);
        }

        public async Task<Investment?> UpdateAsync(string id, string userId, InvestmentUpdateDto dto)
        {
            Investment? investment = await _repository.GetByIdAsync(id, userId);

            if (investment is null)
                return null;

            investment.Name = dto.Name;
            investment.Balance = dto.Balance;
            investment.EstimatedPercent = dto.EstimatedPercent;

            return await _repository.UpdateAsync(investment);
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            return await _repository.DeleteAsync(id, userId);
        }

        public async Task<IEnumerable<Investment>> GetByUserIdAsync(string userId)
        {
            return await _repository.GetByUserIdAsync(userId);
        }

        public async Task<Investment?> WithdrawAsync(string id, string userId, decimal value)
        {
            Investment? investment = await _repository.GetByIdAsync(id, userId);

            if (investment is null)
                return null;

            if (investment.Balance < value)
                throw new InvalidOperationException("Investment has insufficient balance");

            investment.Balance -= value;

            return await _repository.UpdateAsync(investment);
        }

        public async Task<Investment?> DepositAsync(string id, string userId, decimal value)
        {
            Investment? investment = await _repository.GetByIdAsync(id, userId);

            if (investment is null)
                return null;

            investment.Balance += value;

            return await _repository.UpdateAsync(investment);
        }
    }
}
