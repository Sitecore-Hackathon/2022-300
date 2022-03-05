using System;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.Feature.GraphQL.Cache.Models
{
    [ExcludeFromCodeCoverage]
  public class CachingStatus
  {
    public CachingStatus()
    {
      this.StateCode = CachingState.NotFound;
    }

    public CachingState StateCode { get; set; }


    public string StateName => Enum.GetName(typeof (CachingState), (object) this.StateCode);

    
    public static CachingStatus NotFound(string id) => new CachingStatus()
    {
      StateCode = CachingState.NotFound
    };

    
    public static CachingStatus Completed()
    {
      return new CachingStatus()
      {
        StateCode = CachingState.Completed
      };
    }
  }
}
