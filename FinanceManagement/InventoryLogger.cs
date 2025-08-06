using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FinanceManagement
{
    public class InventoryLogger<T> where T : IInventoryEntity
    {
        private List<T> _log = new();
        private readonly string _filePath;

        public InventoryLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(T item)
        {
            _log.Add(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(_log);
        }

        public void SaveToFile()
        {
            try
            {
                using var stream = new FileStream(_filePath, FileMode.Create);
                JsonSerializer.Serialize(stream, _log);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
        }

        public void LoadFromFile()
        {
            try
            {
                if (!File.Exists(_filePath)) return;
                using var stream = new FileStream(_filePath, FileMode.Open);
                var items = JsonSerializer.Deserialize<List<T>>(stream);
                if (items != null)
                    _log = items;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from file: {ex.Message}");
            }
        }
    }
}
