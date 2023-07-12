using CRUD_WebApi.DAL;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebApi.Extensions {
    public static class DbContextRegistrar {
        private const string ConnectionStringName = "EmployeesDB";
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString(ConnectionStringName);
            services.AddDbContext<EmployeesDbContext>(opts => opts.UseSqlServer(connectionString));
            return services;
        }
    }
}
