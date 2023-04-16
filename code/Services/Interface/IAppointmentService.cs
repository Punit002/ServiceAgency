using code.Models;
using code.ViewModels;

namespace code.Services.Interface
{
    public interface IAppointmentService
    { 
        public string CreateAppointment(CreateAppointmentRequestPayload createAppointmentRequestPayload);

        public IEnumerable<ServiceOperatorAppointedSlots> GetAllBookedAppointmensOfOperatorByOperatorId(int operatorId);

        public ServiceOperatorOpenSlots? GetAllOpenSlotsByOperatorId(int operatorId);

        public string CancelAppointmentByAppointmentId(int appointmentId);

        public IEnumerable<Appointment> GetAllAppointments();
    }
}
