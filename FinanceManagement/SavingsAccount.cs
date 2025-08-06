namespace FinanceManagement
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance) { }

        public override void ApplyTransaction(Transaction transaction)
        {
            // Only allow withdrawal if balance is sufficient
            if (_balance >= transaction.Amount)
            {
                _balance -= transaction.Amount;
                System.Console.WriteLine($"SavingsAccount: Withdrawn {transaction.Amount:C} for {transaction.Category}. New Balance: {_balance:C}");
            }
            else
            {
                System.Console.WriteLine($"SavingsAccount: Insufficient funds for {transaction.Amount:C} withdrawal.");
            }
        }

        public override string ToString()
        {
            return $"SavingsAccount {AccountNumber}, Balance: {Balance:C}";
        }
    }
}
