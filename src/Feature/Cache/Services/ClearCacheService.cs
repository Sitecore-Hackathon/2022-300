using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;

namespace Hackathon.Feature.GraphQL.Cache.Services
{
    internal class ClearCacheService : ICachingService
  {
    private readonly ICacheService _cacheService;

    public ClearCacheService(ICacheService cacheService) => this._cacheService = cacheService;

    public void Process() => this._cacheService.ClearCache();
  }
}
