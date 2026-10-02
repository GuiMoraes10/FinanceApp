using FinanceApp.Entities;

namespace FinanceApp.Models
{
    public class InvestmentProjection
    {
        public required Investment Investment { get; set; }
        public decimal[] BalanceProjection { get; set; } = new decimal[12];
    }
}
