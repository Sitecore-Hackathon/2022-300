using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.GraphQL.GraphTypes;
using Hackathon.Feature.GraphQL.Cache.Models;
using Hackathon.Feature.GraphQL.Cache.Services.Interfaces;
using Sitecore.Services.GraphQL.Schemas;
using System.Collections.Generic;

namespace Hackathon.Feature.GraphQL.Cache.GraphQL.Mutations
{
    internal class ClearCacheMutation : 
    RootFieldType<ListGraphType<CachingStatusGraphType>, IEnumerable<CachingStatus>>
  {
    private readonly ICachingResolver _cachingResolver;

    public ClearCacheMutation(ICachingResolver cachingResolver)
      : base("clearCache", "Clears the cache")
    {
      this._cachingResolver = cachingResolver;
    }

    protected override IEnumerable<CachingStatus> Resolve(ResolveFieldContext context)
    {
      return this._cachingResolver.Resolve(MutationType.ClearCache, context);
    }
  }
}
