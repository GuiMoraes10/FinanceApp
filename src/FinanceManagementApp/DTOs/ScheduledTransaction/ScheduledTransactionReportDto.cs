using FinanceManagementApp.Enums;

namespace FinanceManagementApp.DTOs.ScheduledTransaction
{
    public class ScheduledTransactionReportDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public TransactionType Type { get; set; }
        public int? RemainingOccurrences { get; set; }
    }
}
