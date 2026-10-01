using FinanceApp.Entities;

namespace FinanceApp.Repositories.Interfaces
{
    public interface IScheduledTransactionRepository
    {
        public Task<ScheduledTransaction> CreateAsync(ScheduledTransaction transaction);
        public Task<ScheduledTransaction?> GetByIdAsync(string id, string userId);
        public Task<ScheduledTransaction> UpdateAsync(ScheduledTransaction transaction);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<IEnumerable<ScheduledTransaction>> GetByUserIdAsync(string userId);
    }
}
