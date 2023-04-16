using code.Models;
using Microsoft.EntityFrameworkCore;

namespace code.Repository
{
    public class ServiceAgencyContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ServiceAgencyContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: _configuration.GetValue<string>("SqlServer:DataBase"));
        }
        public DbSet<Appointment> Appoinments { get; set; }
        public DbSet<ServiceOperator> ServiceOperators { get; set; }
    }
}
