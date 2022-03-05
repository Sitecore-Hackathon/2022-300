using Hackathon.CLI.Feature.Cache.Services.Interfaces;

namespace Hackathon.CLI.Feature.Cache.Services
{
    internal class CacheService : ICacheService
    {
        public void ClearAllCaches() => Sitecore.Caching.CacheManager.ClearAllCaches();
    }
}
