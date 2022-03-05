using GraphQL.Types;
using Hackathon.CLI.Feature.Cache.Models;
using System.Collections.Generic;

namespace Hackathon.CLI.Feature.Cache.Services.Interfaces
{
    internal interface ICachingResolver
    {
        IEnumerable<CachingStatus> Resolve(ResolveFieldContext context);
    }
}
