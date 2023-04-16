using code.Models;
using code.Repository.Interface;

namespace code.Repository
{
    public class ServiceOperatorRepository : Repository<ServiceOperator>, IServiceOperatorRepository
    {
        public ServiceOperatorRepository(ServiceAgencyContext apiContext) :base(apiContext)
        {

        }

        
    }
}
