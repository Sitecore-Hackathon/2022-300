using Sitecore.DevEx.Client.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Tasks
{
  public class CacheTaskOptions : TaskOptionsBase
  {
    public string Config { get; set; }

    public string EnvironmentName { get; set; }

    public bool Verbose { get; set; }

    public bool Trace { get; set; }


    public override void Validate()
    {
        //this.Require("Config");
        //this.Default("EnvironmentName", (object)"default");
    }
  }
}
