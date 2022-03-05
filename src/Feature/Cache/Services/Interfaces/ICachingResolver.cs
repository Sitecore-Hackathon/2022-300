using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.Models;
using System.Collections.Generic;

namespace Hackathon.Feature.GraphQL.Cache.Services.Interfaces
{
  internal interface ICachingResolver
  {
    IEnumerable<CachingStatus> Resolve(
      MutationType mutationType,
      ResolveFieldContext context);
  }
}
