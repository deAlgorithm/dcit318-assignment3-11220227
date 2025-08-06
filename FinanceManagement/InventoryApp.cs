using System;

namespace FinanceManagement
{
    public class InventoryApp
    {
        private InventoryLogger<InventoryItem> _logger;

        public InventoryApp(string filePath)
        {
            _logger = new InventoryLogger<InventoryItem>(filePath);
        }

        public void SeedSampleData()
        {
            _logger.Add(new InventoryItem(1, "Laptop", 5, DateTime.Now));
            _logger.Add(new InventoryItem(2, "Mouse", 20, DateTime.Now));
            _logger.Add(new InventoryItem(3, "Keyboard", 10, DateTime.Now));
            _logger.Add(new InventoryItem(4, "Monitor", 7, DateTime.Now));
            _logger.Add(new InventoryItem(5, "Printer", 3, DateTime.Now));
        }

        public void SaveData()
        {
            _logger.SaveToFile();
        }

        public void LoadData()
        {
            _logger.LoadFromFile();
        }

        public void PrintAllItems()
        {
            foreach (var item in _logger.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
