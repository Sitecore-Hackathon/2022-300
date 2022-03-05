using Hackathon.Feature.GraphQL.Cache.Client.Models;
using Sitecore.DevEx.Configuration.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hackathon.Feature.GraphQL.Cache.Client.Services
{
    public interface IClearCacheService
  {
    Task<IEnumerable<CacheResultModel>> ClearCacheAsync(
      EnvironmentConfiguration configuration,
      CancellationToken cancellationToken = default (CancellationToken));
  }
}
