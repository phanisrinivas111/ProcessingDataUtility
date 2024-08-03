using ProcessingDataUtility.Entities;
using System.Text.Json;

namespace ProcessingDataUtility.Services
{
    public class ProcessDataService:IProcessDataService
    {
        public async Task<Root> LoadJson(string filePath)
        {
            try
            {
                var jsonData = File.ReadAllText(filePath);
                var dashboardData = JsonSerializer.Deserialize<Root>(jsonData);
                return dashboardData;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON parsing error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public async Task SaveJson(Root data, string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var jsonData = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving JSON: {ex.Message}");
                throw;
            }
        }
    }
}
