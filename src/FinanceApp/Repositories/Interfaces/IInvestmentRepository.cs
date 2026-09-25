using FinanceApp.Entities;

namespace FinanceApp.Repositories.Interfaces
{
    public interface IInvestmentRepository
    {
        public Task<Investment> CreateAsync(Investment investment);
        public Task<Investment?> GetByIdAsync (string id, string userId);
        public Task<Investment> UpdateAsync(Investment investment);
        public Task<bool> DeleteAsync(string id, string userId);
        public Task<IEnumerable<Investment>> GetByUserIdAsync(string userId);
    }
}
