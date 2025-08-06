namespace FinanceManagement
{
    public class Account
    {
        public string AccountNumber { get; }
        protected decimal _balance;
        public decimal Balance => _balance;

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            _balance = initialBalance;
        }

        public virtual void ApplyTransaction(Transaction transaction)
        {
            _balance -= transaction.Amount;
        }

        public override string ToString()
        {
            return $"Account {AccountNumber}, Balance: {Balance:C}";
        }
    }
}
