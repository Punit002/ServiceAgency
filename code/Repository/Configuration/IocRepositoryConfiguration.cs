using code.Repository.Interface;

namespace code.Repository.Configuration
{
    public static class IocRepositoryConfiguration
    {
        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="services"> The services. </param>
        /// <param name="configuration"> The configuration. </param>
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddSingleton<ServiceAgencyContext, ServiceAgencyContext>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IServiceOperatorRepository, ServiceOperatorRepository>();
        }
    }
}
