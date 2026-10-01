namespace FinanceApp.DTOs.Investment
{
    public class InvestmentRegisterDto
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }

        public decimal EstimatedPercent { get; set; }
    }
}
