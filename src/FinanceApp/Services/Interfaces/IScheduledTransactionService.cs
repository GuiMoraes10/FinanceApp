using FinanceApp.DTOs.ScheduledTransaction;
using FinanceApp.Entities;

namespace FinanceApp.Services.Interfaces
{
    public interface IScheduledTransactionService
    {
        public Task<ScheduledTransaction> CreateAsync(ScheduledTransactionRegisterDto dto);
        public Task<ScheduledTransaction?> GetByIdAsync(string id, string userId);
        public Task<ScheduledTransaction?> UpdateAsync(string id, string userId, ScheduledTransactionUpdateDto dto);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<IEnumerable<ScheduledTransaction>> GetByUserIdAsync(string userId);
    }
}
