using Hackathon.Feature.GraphQL.Cache.Client.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache.Client
{
    [ExcludeFromCodeCoverage]
  public static class ContainerExtensions
  {
    public static IServiceCollection AddSchemaPopulation(
      this IServiceCollection serviceCollection)
    {
      serviceCollection.TryAddTransient<IClearCacheService, ClearCacheService>();
      return serviceCollection;
    }
  }
}
