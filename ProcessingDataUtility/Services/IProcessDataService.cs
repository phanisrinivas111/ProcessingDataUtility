using ProcessingDataUtility.Entities;

namespace ProcessingDataUtility.Services
{
    public interface IProcessDataService
    {
        Task<Root> LoadJson(string filePath);
        Task SaveJson(Root data, string filePath);
    }
}
