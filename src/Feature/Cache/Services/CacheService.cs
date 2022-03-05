
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache.Services
{
    [ExcludeFromCodeCoverage]
  internal class CacheService : ICacheService
  {
    public void ClearCache() => Sitecore.Caching.CacheManager.ClearAllCaches();
  }
}
