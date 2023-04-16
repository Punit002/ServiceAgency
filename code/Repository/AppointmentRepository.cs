using code.Models;
using code.Repository.Interface;

namespace code.Repository
{
    public class AppointmentRepository: Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ServiceAgencyContext apiContext) : base(apiContext)
        {

        }
    }
}
