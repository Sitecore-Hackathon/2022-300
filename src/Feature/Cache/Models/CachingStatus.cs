using System;

namespace Hackathon.CLI.Feature.Cache.Models
{
    public class CachingStatus
  {
    public CachingStatus()
    {
      this.StateCode = CachingState.NotStarted;
    }

    public CachingState StateCode { get; set; }
        
    public string StateName => Enum.GetName(typeof (CachingState), (object) this.StateCode);

    public static CachingStatus NotStarted(string id = "") => new CachingStatus()
    {
        StateCode = CachingState.NotStarted
    };

    public static CachingStatus Failed(string id = "") => new CachingStatus()
    {
      StateCode = CachingState.Failed
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
