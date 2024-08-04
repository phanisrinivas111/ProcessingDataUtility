using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProcessData.Entities;
using System.Text.Json;

namespace ProcessData.Services
{
    public class ProcessDataService:IProcessDataService
    {
        public async Task<Root> LoadJson(string filePath)
        {
            try
            {
                var jsonData = File.ReadAllText(filePath);
                var dashboardData = System.Text.Json.JsonSerializer.Deserialize<Root>(jsonData);
                return dashboardData;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
                throw;
            }
            catch (System.Text.Json.JsonException ex)
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
                var jsonData = System.Text.Json.JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving JSON: {ex.Message}");
                throw;
            }
        }
      public async  Task<Root> ProcessData(IFormFile file)
        {
            Root root;
           
            using (var stream = new StreamReader(file.OpenReadStream()))
            {
                var json = await stream.ReadToEndAsync();
                root= JsonConvert.DeserializeObject<Root>(json);
            }
            return root;
        }
    }
}
