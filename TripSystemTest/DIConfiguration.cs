using DataAccess.Repositories.Catalogs.Drivers;
using DataAccess.Repositories.Catalogs.Trips;
using DataAccess.Repositories.CRUD;
using Microsoft.Extensions.DependencyInjection;
using Services.Common.Catalogs;
using Services.Common.Catalogs.Drivers;

namespace TripSystemTest
{
    public class DIConfiguration
    {
        public static void ConfigureDIService(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<ITripRepository, TripRepository>();
            serviceDescriptors.AddScoped<ITripService, TripService>();

            serviceDescriptors.AddScoped<IDriverRepository, DriverRepository>();
            serviceDescriptors.AddScoped<IDriverService, DriverService>();
        }
    }
}
