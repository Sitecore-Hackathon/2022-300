using Hackathon.CLI.Feature.Cache.Services;
using Hackathon.CLI.Feature.Cache.Services.Interfaces;

namespace Hackathon.CLI.Feature.Cache
{
    internal static class CachingFactory
  {
    internal static ICachingService GetService(ICacheService cacheService)
    {
        return (ICachingService) new ClearCacheService(cacheService);
    }
  }
}
