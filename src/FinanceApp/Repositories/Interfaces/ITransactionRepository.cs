using FinanceApp.DTOs.Transaction;
using FinanceApp.Entities;

namespace FinanceApp.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        public Task<Transaction> CreateAsync(Transaction transaction);
        public Task<Transaction?> GetByIdAsync(string id, string userId);
        public Task<Transaction> UpdateAsync(Transaction transaction);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<IEnumerable<Transaction>> GetByUserIdAsync(string userId);
    }
}
