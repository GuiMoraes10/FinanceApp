using FinanceApp.DTOs.ScheduledTransaction;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    public class ScheduledTransactionService(IScheduledTransactionRepository repository) : IScheduledTransactionService
    {
        private readonly IScheduledTransactionRepository _repository = repository;

        public async Task<ScheduledTransaction> CreateAsync(ScheduledTransactionRegisterDto dto)
        {
            ScheduledTransaction transaction = new()
            {
                UserId = dto.UserId,
                Name = dto.Name,
                Value = dto.Value,
                Day = dto.Day,
                Recurring = dto.Recurring,
                RemainingOccurrences = dto.RemainingOcurrences,
                Type = dto.Type,
            };

            return await _repository.CreateAsync(transaction);
        }

        public async Task<ScheduledTransaction?> GetByIdAsync(string id, string userId)
        {
            return await _repository.GetByIdAsync(id, userId);
        }

        public async Task<ScheduledTransaction?> UpdateAsync(string id, string userId, ScheduledTransactionUpdateDto dto)
        {
            ScheduledTransaction? transaction = await _repository.GetByIdAsync(id, userId);

            if (transaction is null)
                return null;

            transaction.Name = dto.Name;
            transaction.Value = dto.Value;
            transaction.Day = dto.Day;
            transaction.Recurring = dto.Recurring;
            transaction.RemainingOccurrences = dto.RemainingOccurrences;
            transaction.Type = dto.Type;

            transaction = await _repository.UpdateAsync(transaction);

            return transaction;
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            return await _repository.DeleteAsync(id, userId);
        }

        public async Task<IEnumerable<ScheduledTransaction>> GetByUserIdAsync(string userId)
        {
            return await _repository.GetByUserIdAsync(userId);
        }
    }
}
