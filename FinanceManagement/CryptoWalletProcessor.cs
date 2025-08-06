using System;

namespace FinanceManagement
{
    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Crypto Wallet: {transaction.Amount:C} for {transaction.Category}");
        }
    }
}
