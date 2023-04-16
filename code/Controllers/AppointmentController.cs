using code.Services.Interface;
using code.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace code.Controllers
{
    /// <summary>
    /// Appointment controller
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        /// <summary>
        /// Create Appointment 
        /// </summary>
        /// <param name="createAppointmentRequestPayload"></param>
        /// <returns>If the creation of the appointment was successful or not</returns>
        [HttpPost(Name = "CreateAppointment")]
        public IActionResult CreateAppointment([FromBody] CreateAppointmentRequestPayload createAppointmentRequestPayload)
        {
            return Ok(_appointmentService.CreateAppointment(createAppointmentRequestPayload));
        }

        /// <summary>
        /// Gets all the booked appointment of the operator
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns>List of booked appointments of the given operator</returns>
        [HttpGet(Name = "GetAllBookedAppointmentsOfOperator")]
        public IActionResult GetAllBookedAppointmensOfOperatorByOperatorId(int operatorId)
        {
            var result = _appointmentService.GetAllBookedAppointmensOfOperatorByOperatorId(operatorId);
            if (result.Any())
            {
                return Ok(result);
            }
            return NoContent();
        }


        /// <summary>
        /// Cancel the appointment
        /// </summary>
        /// <param name="appintmentId"></param>
        /// <returns>Success or failure</returns>
        [HttpPatch(Name = "CancelAppointmentByAppointmentId")]
        public IActionResult CancelAppointmentByAppointmentId(int appintmentId)
        {
            var result = _appointmentService.CancelAppointmentByAppointmentId(appintmentId);
            return Ok(result);
        }

        /// <summary>
        /// Gets all the booked appointment of the operator
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns>List of booked appointments of the given operator</returns>
        [HttpGet(Name = "GetAllOpenSlotsOfAnOperator")]
        public IActionResult GetAllOpenSlotsByOperatorId(int operatorId)
        {
            var result = _appointmentService.GetAllOpenSlotsByOperatorId(operatorId);
            if (result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }

    }

}
