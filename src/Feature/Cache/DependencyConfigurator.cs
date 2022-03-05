using Hackathon.CLI.Feature.Cache.Services;
using Hackathon.CLI.Feature.Cache.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.CLI.Feature.Cache
{

    public class DependencyConfigurator : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddSingleton<ICacheService, CacheService>();
      serviceCollection.AddSingleton<ICachingResolver, CachingResolver>();
    }
  }
}
