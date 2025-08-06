using System;

namespace FinanceManagement
{
    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Mobile Money: {transaction.Amount:C} for {transaction.Category}");
        }
    }
}
