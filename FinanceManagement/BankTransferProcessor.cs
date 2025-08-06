using System;

namespace FinanceManagement
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Bank Transfer: {transaction.Amount:C} for {transaction.Category}");
        }
    }
}
