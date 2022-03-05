using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.Models;
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;
using System.Collections.Generic;

namespace Hackathon.Feature.GraphQL.Cache.Services
{
    internal class CachingResolver : ICachingResolver
  {
    private readonly ICacheService _cacheService;
    
    public CachingResolver(ICacheService cacheService)
    {
      this._cacheService = cacheService;
    }

    public IEnumerable<CachingStatus> Resolve(
      MutationType mutationType,
      ResolveFieldContext context)
    {
      ICachingService service = CachingFactory.GetService(mutationType, this._cacheService);
      List<CachingStatus> resultList = new List<CachingStatus>();
      service.Process();
        resultList.Add(CachingStatus.Completed());
        return (IEnumerable<CachingStatus>) resultList;
    }
  }
}
