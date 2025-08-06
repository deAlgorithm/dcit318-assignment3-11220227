# DCIT 318 – Programming II Assignment 3

## Finance Management and Inventory System

This C# console application demonstrates a modular finance management and inventory system using records, interfaces, sealed classes, and generic logging. Each class is organized in its own file for clarity and maintainability.

### Features

- **Transaction Tracking:**
  - `Transaction` record models financial transactions.
  - Multiple transaction processors: `BankTransferProcessor`, `MobileMoneyProcessor`, `CryptoWalletProcessor`.
- **Account Management:**
  - `Account` base class and sealed `SavingsAccount` subclass with custom transaction logic.
- **Inventory Management:**
  - `InventoryItem` record implements marker interface `IInventoryEntity`.
  - Generic `InventoryLogger<T>` for logging and file persistence (JSON).
  - `InventoryApp` integration layer for seeding, saving, loading, and printing inventory.
- **Console Output:**
  - Colored sections for clarity.
  - Clean printing via `.ToString()` overrides.
  - Inventory file path displayed at startup.

### File Structure

- `Transaction.cs` – Transaction record
- `ITransactionProcessor.cs` – Transaction processor interface
- `BankTransferProcessor.cs`, `MobileMoneyProcessor.cs`, `CryptoWalletProcessor.cs` – Processor implementations
- `Account.cs` – Base account class
- `SavingsAccount.cs` – Sealed savings account class
- `IInventoryEntity.cs` – Marker interface
- `InventoryItem.cs` – Inventory item record
- `InventoryLogger.cs` – Generic logger for inventory
- `InventoryApp.cs` – Inventory integration layer
- `Program.cs` – Main entry point

### How to Run

1. Ensure [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) is installed.
2. In the project directory, run:
   ```bash
   dotnet run --project FinanceManagement/FinanceManagement.csproj
   ```

### Example Output

```
Inventory file path: inventory.json

--- Seeding and Saving Inventory ---

--- Loading and Printing Inventory ---

Id: 1, Name: Laptop, Quantity: 5, DateAdded: 2025-08-06 09:43
Id: 2, Name: Mouse, Quantity: 20, DateAdded: 2025-08-06 09:43
...

--- Demonstrate Transaction Processors ---

Bank Transfer: ¤150.00 for Office Supplies
Mobile Money: ¤150.00 for Office Supplies
Crypto Wallet: ¤150.00 for Office Supplies

--- Demonstrate Account and SavingsAccount behaviors ---

Account ACC123, Balance: ¤400.00
SavingsAccount: Withdrawn ¤50.00 for Withdrawal. New Balance: ¤150.00
SavingsAccount: Insufficient funds for ¤300.00 withdrawal.
SavingsAccount SAV456, Balance: ¤150.00
```

### Notes

- All inventory data is saved to and loaded from `inventory.json` in the project directory.
- Console colors may not display in all terminals.