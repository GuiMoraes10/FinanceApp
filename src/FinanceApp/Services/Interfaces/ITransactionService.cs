using FinanceApp.DTOs.Transaction;
using FinanceApp.Entities;

namespace FinanceApp.Services.Interfaces
{
    public interface ITransactionService
    {
        public Task<Transaction> CreateAsync(TransactionRegisterDto dto);
        public Task<Transaction?> GetByIdAsync(string id, string userId);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<Transaction?> UpdateAsync(string id, string userId, TransactionUpdateDto dto);
        public Task<IEnumerable<Transaction>> GetByUserId(string userId);
    }
}
