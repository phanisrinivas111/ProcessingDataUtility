using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using ProcessData.Entities;
using ProcessData.Services;

namespace ProcessingDataUtility.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IProcessDataService _processDataService;

        public DashboardController(IProcessDataService processDataService)
        {
            _processDataService = processDataService;
        }

        [HttpGet("load")]
        public IActionResult LoadDashboard()
        {
            try
            {
                var data = _processDataService.LoadJson("path_to_json_file.json");
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("save")]
        public IActionResult SaveDashboard([FromBody] Root dashboardData)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                string json = System.Text.Json.JsonSerializer.Serialize(dashboardData, options);
                _processDataService.SaveJson(dashboardData, "path_to_output_json_file.json");
                return Ok(json);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("No file uploaded.");
                }
                else if (Path.GetExtension(file.FileName).ToUpper() != ".JSON")
                {
                    return BadRequest("Upload json file.");
                }

                return Ok(await _processDataService.ProcessData(file));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }
    }
}
