using System;
using FinanceManagement;

namespace FinanceManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "inventory.json";
            var app = new InventoryApp(filePath);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Inventory file path: {filePath}\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- Seeding and Saving Inventory ---\n");
            Console.ResetColor();
            app.SeedSampleData();
            app.SaveData();

            // Simulate new session
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- Loading and Printing Inventory ---\n");
            Console.ResetColor();
            app = new InventoryApp(filePath);
            app.LoadData();
            app.PrintAllItems();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--- Demonstrate Transaction Processors ---\n");
            Console.ResetColor();
            var transaction = new Transaction(1, DateTime.Now, 150.00m, "Office Supplies");
            ITransactionProcessor bankProcessor = new BankTransferProcessor();
            ITransactionProcessor mobileProcessor = new MobileMoneyProcessor();
            ITransactionProcessor cryptoProcessor = new CryptoWalletProcessor();

            bankProcessor.Process(transaction);
            mobileProcessor.Process(transaction);
            cryptoProcessor.Process(transaction);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n--- Demonstrate Account and SavingsAccount behaviors ---\n");
            Console.ResetColor();
            var account = new Account("ACC123", 500.00m);
            account.ApplyTransaction(new Transaction(2, DateTime.Now, 100.00m, "Withdrawal"));
            Console.WriteLine(account);

            var savings = new SavingsAccount("SAV456", 200.00m);
            savings.ApplyTransaction(new Transaction(3, DateTime.Now, 50.00m, "Withdrawal"));
            savings.ApplyTransaction(new Transaction(4, DateTime.Now, 300.00m, "Large Withdrawal"));
            Console.WriteLine(savings);
        }
    }
}
