using GraphQL.Types;
using Hackathon.CLI.Feature.Cache.Models;
using Hackathon.CLI.Feature.Cache.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Hackathon.CLI.Feature.Cache.Services
{
    internal class CachingResolver : ICachingResolver
  {
    private readonly ICacheService _cacheService;
    
    public CachingResolver(ICacheService cacheService)
    {
      this._cacheService = cacheService;
    }

    public IEnumerable<CachingStatus> Resolve(
      ResolveFieldContext context)
    {
        List<CachingStatus> resultList = new List<CachingStatus>();
        try
        {
            ICachingService service = CachingFactory.GetService(this._cacheService);
            service.Process();
            resultList.Add(CachingStatus.Completed());
        }
        catch (Exception ex)
        {
            resultList.Add(CachingStatus.Failed());
        }
        return (IEnumerable<CachingStatus>)resultList;
    }
  }
}
