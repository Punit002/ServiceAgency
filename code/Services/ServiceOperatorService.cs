using code.Models;
using code.Repository.Interface;
using code.Services.Interface;

namespace code.Services
{
    public class ServiceOperatorService : IServiceOperatorService
    {
        private readonly IServiceOperatorRepository _serviceOperatorRepository;

        public ServiceOperatorService(IServiceOperatorRepository serviceOperatorRepository)
        {
            _serviceOperatorRepository = serviceOperatorRepository;
        }

        public IEnumerable<ServiceOperator> GetAllServiceOperators()
        {
            return _serviceOperatorRepository.GetAll();
        }
    }
}
