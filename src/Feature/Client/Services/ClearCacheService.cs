using GraphQL.Common.Request;
using Hackathon.Feature.GraphQL.Cache.Client.Models;
using Sitecore.DevEx.Configuration.Models;
using Sitecore.DevEx.Serialization.Client.Datasources.Sc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hackathon.Feature.GraphQL.Cache.Client.Services
{
    public class ClearCacheService : IClearCacheService
  {
    private readonly ISitecoreApiClient _apiClient;

    public ClearCacheService(ISitecoreApiClient apiClient) => this._apiClient = apiClient;

    public async Task<IEnumerable<CacheResultModel>> ClearCacheAsync(
      EnvironmentConfiguration configuration,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      ISitecoreApiClient apiClient = this._apiClient;
      if (apiClient.Endpoint == null)
      {
        EnvironmentConfiguration environmentConfiguration;
        apiClient.Endpoint = environmentConfiguration = configuration;
      }
      return await this._apiClient.RunQuery<IEnumerable<CacheResultModel>>("/sitecore/api/management", new GraphQLRequest()
      {
        Query = "mutation(){\n    clearCache(){\n    stateCode\n    stateName}}"
      }, "rebuildIndex", cancellationToken);
    }
  }
}
