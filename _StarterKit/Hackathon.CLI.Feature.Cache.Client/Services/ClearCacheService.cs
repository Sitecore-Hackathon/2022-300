using GraphQL.Common.Request;
using Sitecore.DevEx.Configuration.Models;
using Hackathon.CLI.Feature.Cache.Client.Models;
using Sitecore.DevEx.Serialization.Client.Datasources.Sc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hackathon.CLI.Feature.Cache.Client.Services
{
  public class ClearCacheService : IClearCacheService
  {
    private const string _rebuildIndex = "mutation($indexNames:[String]){\nrebuildIndex(indexNames:$indexNames){\n     id\n    indexName\n    processedCount\n    stateCode\n    stateName}}";
    private readonly ISitecoreApiClient _apiClient;

    public ClearCacheService(ISitecoreApiClient apiClient) => this._apiClient = apiClient;


    public Task<IEnumerable<CacheResultModel>> ClearCacheAsync(EnvironmentConfiguration configuration,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        ISitecoreApiClient apiClient = this._apiClient;
        if (apiClient.Endpoint == null)
        {
            EnvironmentConfiguration environmentConfiguration;
            apiClient.Endpoint = environmentConfiguration = configuration;
        }
        return await this._apiClient.RunQuery<IEnumerable<CacheResultModel>>("/sitecore/api/management", new GraphQLRequest()
        {
            Query = "mutation($indexNames:[String]){\nrebuildIndex(indexNames:$indexNames){\n     id\n    indexName\n    processedCount\n    stateCode\n    stateName}}",
        }, "clearCache", cancellationToken);
    }
  }
}
