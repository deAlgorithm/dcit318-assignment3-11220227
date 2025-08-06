using System;

namespace FinanceManagement
{
    public record InventoryItem(int Id, string Name, int Quantity, DateTime DateAdded) : IInventoryEntity
    {
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, DateAdded: {DateAdded:yyyy-MM-dd HH:mm}";
        }
    }
}
