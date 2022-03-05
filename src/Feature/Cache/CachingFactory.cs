using Hackathon.Feature.GraphQL.Cache.Models;
using Hackathon.Feature.GraphQL.Cache.Services;
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;

namespace Hackathon.Feature.GraphQL.Cache
{
    internal static class CachingFactory
  {
    internal static ICachingService GetService(
      MutationType mutationType,
      ICacheService cacheService)
    {
      return (ICachingService) new ClearCacheService(cacheService);
    }
  }
}
