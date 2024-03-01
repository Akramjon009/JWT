using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmailSenderApp.Infrastracture
{
    public static class Ingection
    {
        public static IServiceCollection AddInfrastruction(this IServiceCollection service, IConfiguration configuration) 
        {
            service.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectPostgres"));
            });
            return service;
        }
    }
}
