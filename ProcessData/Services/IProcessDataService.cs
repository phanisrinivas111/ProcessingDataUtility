using Microsoft.AspNetCore.Http;
using ProcessData.Entities;

namespace ProcessData.Services
{
    public interface IProcessDataService
    {
        Task<Root> LoadJson(string filePath);
        Task<Root> ProcessData(IFormFile file);
        Task SaveJson(Root data, string filePath);


    }
}
