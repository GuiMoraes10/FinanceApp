using FinanceApp.Entities;

namespace FinanceApp.DTOs.Transaction
{
    public class TransactionUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public TransactionCategory Category { get; set; }
    }
}
