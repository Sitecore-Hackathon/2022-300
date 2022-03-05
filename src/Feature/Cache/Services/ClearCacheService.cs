using Hackathon.CLI.Feature.Cache.Services.Interfaces;

namespace Hackathon.CLI.Feature.Cache.Services
{
    class ClearCacheService : ICachingService
    {
        private readonly ICacheService _cacheService;

        public ClearCacheService(ICacheService cacheService) => this._cacheService = cacheService;

        public async void Process()
        {
            this._cacheService.ClearAllCaches();
        }
    }
}
