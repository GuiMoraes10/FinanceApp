namespace FinanceApp.Services.Interfaces
{
    public interface IFinancialProjectionService
    {
        public Task<decimal> GetMonthBalance(string userId);
        public Task<decimal> GetMonthlyScheduledExpenses(string userId);
        public Task<decimal> GetMonthlyScheduledIncomes(string userId);
        public Task<List<InvestmentProjection>> GetUserInvestmentsProjection(string userId);
        public Task<IEnumerable<MonthRelatory>> GetYearlyRelatory(string userId);
    }
}
