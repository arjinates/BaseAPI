using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SoftwareLab.Core.Features.User.Command.CreateUser;
using System.Net.NetworkInformation;
using System.Reflection;

namespace SoftwareLab.Core.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static void addApplicationCore(this IServiceCollection services)
        {
           services.AddMediatR(cfg => {
               cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly);
           });
        }
    }
}
