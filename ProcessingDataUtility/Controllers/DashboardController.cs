using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessingDataUtility.Entities;
using ProcessingDataUtility.Services;
using System.Text.Json.Serialization;
using System.Text.Json;

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

                string json = JsonSerializer.Serialize(dashboardData, options);
                _processDataService.SaveJson(dashboardData, "path_to_output_json_file.json");
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
