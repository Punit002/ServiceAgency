using code.Models;
using code.Repository.Interface;
using code.Services.Interface;
using code.ViewModels;

namespace code.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IServiceOperatorService _serviceOperatorService;
        public AppointmentService(IAppointmentRepository appointmentRepository, IServiceOperatorService serviceOperatorService)
        {
            _appointmentRepository = appointmentRepository;
            _serviceOperatorService = serviceOperatorService;
        }

        public string CreateAppointment(CreateAppointmentRequestPayload createAppointmentRequestPayload)
        {
            IEnumerable<Appointment> appointments = GetAllAppointments();

            var busyOperators = appointments.Where(item => item.Time == createAppointmentRequestPayload.Time && item.Status == Status.Booked).Select(x => x.OperatorId);

            var serviceOperators = _serviceOperatorService.GetAllServiceOperators();

            var nonBusyOperators = serviceOperators.Where(item => !busyOperators.Contains(item.OperatorId));

            if (nonBusyOperators.Any())
            {
                var appointment = new Appointment(Guid.NewGuid(), appointments.Count() + 1, createAppointmentRequestPayload.Description ?? string.Empty, Status.Booked, createAppointmentRequestPayload.Time, new DateTime(2023, 4, 16).Date, nonBusyOperators.First().OperatorId);
                var result = _appointmentRepository.Insert(appointment);

                return $"Appointment Created Successfully, Appointment Id is {result.AppointmentId}";
            }

            return "All operator busy for this time slot, Try Again with different time slot !!";
        }

        public IEnumerable<ServiceOperatorAppointedSlots> GetAllBookedAppointmensOfOperatorByOperatorId(int operatorId)
        {
            var bookedAppointmentsByOperatorId = GetAllAppointments().Where(item => item.OperatorId == operatorId && item.Status == Status.Booked);

            if (bookedAppointmentsByOperatorId.Any())
            {
                var result = new List<ServiceOperatorAppointedSlots>();

                foreach (var appointment in bookedAppointmentsByOperatorId)
                {
                    result.Add(new ServiceOperatorAppointedSlots(appointment.OperatorId, appointment.Time, appointment.AppointmentId));
                }

                return result;
            }
            return new List<ServiceOperatorAppointedSlots>();
        }
    
        public string CancelAppointmentByAppointmentId(int appointmentId)
        {
            var appointment = GetAllAppointments().FirstOrDefault((item) => item.AppointmentId == appointmentId);

            if(appointment != null)
            {
                appointment.Status = Status.Cancel;
                _appointmentRepository.Update(appointment);
                return "Successfully canceled the Appointment";
            }

            return $"No appointment found with this {appointmentId}, please try with correct appointmentId";
        }

        public ServiceOperatorOpenSlots? GetAllOpenSlotsByOperatorId(int operatorId)
        {
            var appoinmentsByOperatorId = GetAllAppointments().Where((item) => item.OperatorId == operatorId && item.Status == Status.Booked);

            if(appoinmentsByOperatorId.Count() == 24)
            {
                return null;
            }

            return new ServiceOperatorOpenSlots(operatorId, 24 - appoinmentsByOperatorId.Count());
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _appointmentRepository.GetAll();
        }
    }
}
