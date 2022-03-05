using Hackathon.Feature.GraphQL.Cache.Services;
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache
{
    [ExcludeFromCodeCoverage]
  public class DependencyConfigurator : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddSingleton<ICacheService, CacheService>();
      serviceCollection.AddSingleton<ICachingResolver, CachingResolver>();
    }
  }
}
