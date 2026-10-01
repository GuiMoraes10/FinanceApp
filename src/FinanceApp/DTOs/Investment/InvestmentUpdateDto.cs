namespace FinanceApp.DTOs.Investment
{
    public class InvestmentUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }

        public decimal EstimatedPercent { get; set; }
    }
}
