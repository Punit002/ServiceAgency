using System.ComponentModel.DataAnnotations;

namespace code.ViewModels
{
    /// <summary>
    /// Create Appointment payload
    /// </summary>
    public class CreateAppointmentRequestPayload
    {
        public CreateAppointmentRequestPayload(int time)
        {
            Time = time;
        }

        /// <summary>
        /// Description about the appointment
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Time of the appointment (0 to 24)
        /// </summary>
        [Required]
        [Range(0, 24, ErrorMessage = "Please Enter the time between 0 to 24, Example : 12")]
        public int Time { get; set; }
    }
}
