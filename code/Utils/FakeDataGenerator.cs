using code.Models;
using code.Repository;

namespace code.Utils
{
    public static class FakeDataGenerator
    {
        public static void AddDummyServiceOperators(ServiceAgencyContext serviceAgencyContext)
        {
            var serviceOperators = new List<ServiceOperator>()
            {
                new ServiceOperator(Guid.NewGuid(), "Vishal", "Patel", 1),
                new ServiceOperator(Guid.NewGuid(), "Anand", "KR", 2),
                new ServiceOperator(Guid.NewGuid(), "Monika", "Kulkarni", 3)

            };

            serviceAgencyContext.ServiceOperators.AddRange(serviceOperators);
            serviceAgencyContext.SaveChanges();
        }
    }
}
