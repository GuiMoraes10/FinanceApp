namespace FinanceApp.Entities
{
    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; } = 0;
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public TransactionCategory Category { get; set; }
    }

    public enum TransactionType
    {
        Income,
        Expense
    }

    public enum TransactionCategory
    {
        Bill,
        Food,
        Transport,
        Leisure,
        CreditCard,
        Investment,
        Salary,
        Other
    }
}
