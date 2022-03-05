using GraphQL.Types;
using Hackathon.Feature.GraphQL.Cache.Models;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache.GraphQL.GraphTypes
{
    [ExcludeFromCodeCoverage]
  internal class CachingStateGraphType : EnumerationGraphType
  {
    public CachingStateGraphType()
    {
      Type enumType = typeof (CachingState);
      this.Name = enumType.Name;
      foreach (object obj in Enum.GetValues(enumType))
        this.AddValue(obj.ToString(), string.Format("Code: {0}", (object) (int) obj), (object) (int) obj);
    }
  }
}
