using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwareLab.Core.Repositories;
using SoftwareLab.Core.Services;
using SoftwareLab.Infrastructure.Contexts;
using SoftwareLab.Infrastructure.Repositorries;
using SoftwareLab.Infrastructure.Services;

namespace SoftwareLab.Infrastructure.DependecyInjection
{
    public static class ServiceRegistration
    {
        public static void addInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IEmailService, EmailService>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
