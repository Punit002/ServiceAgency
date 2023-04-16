using code.Services.Interface;

namespace code.Services.Configuration
{
    public static class IocServicesConfiguration
    {
        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="services"> The services. </param>
        /// <param name="configuration"> The configuration. </param>
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IServiceOperatorService, ServiceOperatorService>();
        }
    }
}
