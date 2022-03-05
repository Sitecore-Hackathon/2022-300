using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.Models;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache.GraphQL.GraphTypes
{
    [ExcludeFromCodeCoverage]
  internal class CachingStatusGraphType : ObjectGraphType<CachingStatus>
  {
    public CachingStatusGraphType()
    {
      this.Name = "CachingStatus";
      this.Field<IntGraphType>("stateCode", "Caching state code.", (QueryArguments) null, new Func<ResolveFieldContext<CachingStatus>, object>(CachingStatusGraphType.ResolveCachingStateCode), (string) null);
      this.Field<CachingStateGraphType>("stateName", "Caching state name.", (QueryArguments) null, new Func<ResolveFieldContext<CachingStatus>, object>(CachingStatusGraphType.ResolveStateName), (string) null);
    }

    private static object ResolveStateName(ResolveFieldContext<CachingStatus> context) => (object) context.Source.StateCode;

    private static object ResolveCachingStateCode(ResolveFieldContext<CachingStatus> context) => (object) (int) context.Source.StateCode;
        
  }
}
