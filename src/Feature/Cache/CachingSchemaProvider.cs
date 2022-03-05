using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.GraphQL.Mutations;
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;
using Sitecore.Abstractions;
using Sitecore.Services.GraphQL.Schemas;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache
{
    [ExcludeFromCodeCoverage]
  internal class CachingSchemaProvider : SchemaProviderBase
  {
    private readonly BaseJobManager _baseJobManager;
    private readonly ICachingResolver _cachingResolver;
    private readonly ICacheService _cacheService;

    public CachingSchemaProvider(
      BaseJobManager baseJobManager,
      ICachingResolver cachingResolver,
      ICacheService cacheService)
    {
      this._baseJobManager = baseJobManager;
      this._cachingResolver = cachingResolver;
      this._cacheService = cacheService;
    }

    public override IEnumerable<FieldType> CreateRootQueries()
    {
        return null;
    }

    public override IEnumerable<FieldType> CreateRootMutations()
    {
        yield return (FieldType) new ClearCacheMutation(this._cachingResolver);
    }
  }
}
