using Agro_Aggregate;
using Agro_DTO;
using Agro_Handler;
using Agro_Handler.IHandler;
using Agro_Repository.IRepository;
using Agro_Repository.Repositroy;

namespace Agro
{
    public class Scopes
    {
        public static void ScopeServices(IServiceCollection services)
        {
            services.AddScoped<ILocationHandler, LocationHandler>();
            services.AddScoped<ILocationRepository, LocationRepository>();

        }

    }
}
