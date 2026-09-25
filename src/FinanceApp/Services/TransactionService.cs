using FinanceApp.DTOs.Transaction;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    public class TransactionService(ITransactionRepository transactionRepository, IUserRepository userRepository) : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;
        private readonly IUserRepository _userRepository = userRepository;


        public async Task<Transaction?> GetByIdAsync(string id, string userId)
        {
            return await _transactionRepository.GetByIdAsync(id, userId);
        }

        public async Task<IEnumerable<Transaction>> GetByUserId(string userId)
        {
            return await _transactionRepository.GetByUserIdAsync(userId);
        }

        public async Task<Transaction> CreateAsync(TransactionRegisterDto dto)
        {
            Transaction transaction = new Transaction()
            {
                Name = dto.Name,
                UserId = dto.UserId,
                Category = dto.Category,
                Date = dto.Date,
                Type = dto.Type,
                Value = dto.Value,
            };

            var user = await _userRepository.GetByIdAsync(dto.UserId);

            if (user is null)
                throw new InvalidOperationException("User was not found");

            if (dto.Type == TransactionType.Expense && dto.Value > user.Balance)
                throw new InvalidOperationException("User has insufficient balance");

            transaction = await _transactionRepository.CreateAsync(transaction);

            if (dto.Type == TransactionType.Expense)
            {
                user.Balance -= dto.Value;
            }
            else
            {
                user.Balance += dto.Value;
            }

            try
            {
                await _userRepository.UpdateAsync(user);
            }
            catch
            {
                await _transactionRepository.DeleteAsync(transaction.Id, user.Id);
                throw;
            }

            return transaction;
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            var transaction = await _transactionRepository.GetByIdAsync(id, userId);
            var user = await _userRepository.GetByIdAsync(userId);

            if (transaction is null)
                throw new InvalidOperationException("Transaction was not found");

            if (user is null)
                throw new InvalidOperationException("user was not found");

            if (!await _transactionRepository.DeleteAsync(id, userId))
                return false;

            if (transaction.Type == TransactionType.Income)
            {
                user.Balance -= transaction.Value;
            }
            else
            {
                user.Balance += transaction.Value;
            }

            try
            {
                await _userRepository.UpdateAsync(user);
            }
            catch
            {
                // recria a transação caso a atualizacao do usuario falhe
                await _transactionRepository.CreateAsync(transaction);

                throw;
            }

            return true;
        }

        public async Task<Transaction?> UpdateAsync(string id, string userId, TransactionUpdateDto dto)
        {
            var transaction = await _transactionRepository.GetByIdAsync(id, userId);
            var user = await _userRepository.GetByIdAsync(userId);

            if (transaction is null)
                throw new InvalidOperationException("Transaction was not found");

            if (user is null)
                throw new InvalidOperationException("user was not found");

            if (transaction.Type == TransactionType.Income)
            {
                user.Balance -= transaction.Value;
            }
            else
            {
                user.Balance += transaction.Value;
            }

            if (dto.Type == TransactionType.Expense && dto.Value > user.Balance)
                throw new InvalidOperationException("User has insufficient balance");

            var oldValue = transaction.Value;
            var oldType = transaction.Type;

            transaction.Name = dto.Name;
            transaction.Value = dto.Value;
            transaction.Date = dto.Date;
            transaction.Type = dto.Type;
            transaction.Category = dto.Category;

            if (transaction.Type == TransactionType.Income)
            {
                user.Balance += transaction.Value;
            }
            else
            {
                user.Balance -= transaction.Value;
            }

            try
            {
                var updatedTransaction =
                    await _transactionRepository.UpdateAsync(transaction);

                await _userRepository.UpdateAsync(user);

                return updatedTransaction;
            }
            catch
            {
                if (oldType == TransactionType.Income)
                {
                    user.Balance -= transaction.Value;
                    user.Balance += oldValue;
                }
                else
                {
                    user.Balance += transaction.Value;
                    user.Balance -= oldValue;
                }

                try
                {
                    await _userRepository.UpdateAsync(user);
                }
                catch
                {

                }

                throw;
            }
        }
    }
}
