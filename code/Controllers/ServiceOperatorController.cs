using code.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace code.Controllers
{
    /// <summary>
    /// Service Operator controller
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class ServiceOperatorController : ControllerBase
    {
        private readonly IServiceOperatorService _serviceOperatorService;

        public ServiceOperatorController(IServiceOperatorService serviceOperatorService)
        {
            _serviceOperatorService = serviceOperatorService;
        }

        /// <summary>
        /// Get All Operators
        /// </summary>
        /// <returns>List of operators present</returns>
        [HttpGet(Name = "GetAllServiceOperators")]
        public IActionResult GetAllServiceOperators()
        {
            var serviceOperators = _serviceOperatorService.GetAllServiceOperators();
            if (serviceOperators.Any())
            {
                return Ok(serviceOperators);
            }
            return NoContent();
        }
    }
}