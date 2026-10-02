using FinanceApp.DTOs.ScheduledTransaction;

namespace FinanceApp.Models
{
    public class MonthRelatory
    {
        public int Month { get; set; }
        public decimal EndingBalance { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public IEnumerable<ScheduledTransactionReportDto>? Transactions { get; set; } = [];
    }
}
