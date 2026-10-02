using FinanceApp.DTOs.ScheduledTransaction;
using FinanceApp.Entities;
using FinanceApp.Enums;
using FinanceApp.Models;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    // Esta classe irá fazer a projeção financeira com o passar dos meses para um usuário, além do balanço ao final do mes
    public class FinancialProjectionService(IScheduledTransactionService scheduledTransactionService, IUserService userService, IInvestmentService investmentService) : IFinancialProjectionService
    {
        private readonly IScheduledTransactionService _scheduledTransationService = scheduledTransactionService;
        private readonly IUserService _userService = userService;
        private readonly IInvestmentService _investmentService = investmentService;

        public async Task<decimal> GetMonthlyBalance(string userId)
        {
            var scheduledTransations = await _scheduledTransationService.GetByUserIdAsync(userId);

            var user = await _userService.GetUserById(userId);

            if (user is null)
                throw new InvalidOperationException("Failed to get user");

            decimal monthBalance = user.Balance;

            if (scheduledTransations != null && scheduledTransations.Any())
            {
                foreach (var transaction in scheduledTransations)
                {
                    if (transaction.Type == TransactionType.Income)
                    {
                        monthBalance += transaction.Value;
                    }
                    else
                    {
                        monthBalance -= transaction.Value;
                    }
                }
            }

            return monthBalance;
        }

        public async Task<decimal> GetMonthlyScheduledExpenses(string userId)
        {
            var scheduledTransations = await _scheduledTransationService.GetByUserIdAsync(userId);

            decimal expenseValue = 0;

            if (scheduledTransations != null && scheduledTransations.Any())
            {
                foreach (var transaction in scheduledTransations)
                {
                    if (transaction.Type == TransactionType.Expense)
                    {
                        expenseValue += transaction.Value;
                    }
                }
            }

            return expenseValue;
        }

        public async Task<decimal> GetMonthlyScheduledIncomes(string userId)
        {
            var scheduledTransations = await _scheduledTransationService.GetByUserIdAsync(userId);

            decimal incomeValue = 0;

            if (scheduledTransations != null && scheduledTransations.Any())
            {
                foreach (var transaction in scheduledTransations)
                {
                    if (transaction.Type == TransactionType.Income)
                    {
                        incomeValue += transaction.Value;
                    }
                }
            }

            return incomeValue;
        }

        public async Task<List<InvestmentProjection>> GetUserInvestmentsProjection(string userId)
        {
            var investments = await _investmentService.GetByUserIdAsync(userId);

            if (!investments.Any())
                throw new InvalidOperationException("Failed to get user investments");

            List<InvestmentProjection> investmentProjections = [];

            foreach (var investment in investments)
            {
                decimal[] projection = new decimal[12];

                decimal monthBalance = investment.Balance;

                for (int i = 0; i < 12; i++)
                {
                    monthBalance += monthBalance * investment.EstimatedPercent / 100;

                    monthBalance = Math.Round(monthBalance, 2, MidpointRounding.ToEven);

                    projection[i] = monthBalance;
                }

                InvestmentProjection investmentProjection = new()
                {
                    Investment = investment,
                    BalanceProjection = projection
                };

                investmentProjections.Add(investmentProjection);
            }

            return investmentProjections;
        }

        public async Task<IEnumerable<MonthRelatory>> GetYearlyRelatory(string userId)
        {
            var scheduledTransations = await _scheduledTransationService.GetByUserIdAsync(userId);

            var user = await _userService.GetUserById(userId) ?? throw new InvalidOperationException("Failed to get user");

            decimal initialBalance = user.Balance;

            var transactions = ScheduledTransactionsToDtoList(scheduledTransations);

            return ScheduledTransactionDtoToMonthList(initialBalance, transactions);
        }

        private List<ScheduledTransactionReportDto> ScheduledTransactionsToDtoList(IEnumerable<ScheduledTransaction> scheduledTransactions)
        {
            var transactions = new List<ScheduledTransactionReportDto>();

            foreach (var transaction in scheduledTransactions)
            {
                ScheduledTransactionReportDto schedule = new();

                int? remaining;

                if (transaction.Recurring)
                {
                    remaining = transaction.RemainingOccurrences;
                }
                else
                {
                    remaining = 1;
                }

                schedule.Name = transaction.Name;
                schedule.Type = transaction.Type;
                schedule.Value = transaction.Value;
                schedule.RemainingOccurrences = remaining;

                transactions.Add(schedule);
            }

            return transactions;
        }

        private List<MonthRelatory> ScheduledTransactionDtoToMonthList(decimal initialBalance, List<ScheduledTransactionReportDto> transactions)
        {
            List<MonthRelatory> months = [];

            for (int i = 0; i < 12; i++)
            {
                var monthTransactions = new List<ScheduledTransactionReportDto>();

                decimal initialMonthBalance;

                if (i == 0)
                {
                    initialMonthBalance = initialBalance;
                }
                else
                {
                    initialMonthBalance = months[i - 1].EndingBalance;
                }

                decimal monthBalance = initialMonthBalance;
                decimal income = 0;
                decimal expense = 0;

                foreach (var t in transactions.ToList())
                {
                    // Se já não possui ocorrências, ignora
                    if (t.RemainingOccurrences is not null && t.RemainingOccurrences <= 0)
                        continue;

                    // Salva uma cópia do estado considerado neste mês
                    monthTransactions.Add(new ScheduledTransactionReportDto
                    {
                        Name = t.Name,
                        Value = t.Value,
                        Type = t.Type,
                        RemainingOccurrences = t.RemainingOccurrences
                    });

                    if (t.Type == TransactionType.Income)
                    {
                        monthBalance += t.Value;
                        income += t.Value;
                    }
                    else
                    {
                        monthBalance -= t.Value;
                        expense += t.Value;
                    }

                    if (t.RemainingOccurrences is not null)
                    {
                        t.RemainingOccurrences--;

                        if (t.RemainingOccurrences <= 0)
                        {
                            transactions.Remove(t);
                        }
                    }
                }

                months.Add(new MonthRelatory()
                {
                    EndingBalance = monthBalance,
                    Month = i + 1,
                    Income = income,
                    Expenses = expense,
                    Transactions = monthTransactions
                });
            }

            return months;
        }
    }
}
