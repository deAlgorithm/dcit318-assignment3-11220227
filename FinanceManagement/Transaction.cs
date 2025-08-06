using System;

namespace FinanceManagement
{
    public record Transaction(int Id, DateTime Date, decimal Amount, string Category)
    {
        public override string ToString()
        {
            return $"Id: {Id}, Date: {Date:yyyy-MM-dd HH:mm}, Amount: {Amount:C}, Category: {Category}";
        }
    }
}
