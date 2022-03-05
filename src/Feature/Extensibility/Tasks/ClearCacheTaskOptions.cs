using Sitecore.DevEx.Client.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Tasks
{
    public class ClearCacheTaskOptions : TaskOptionsBase
  {
    public bool Clear { get; set; }

    public override void Validate()
    {
        this.Require("Config");
        this.Default("EnvironmentName", (object)"default");
        if (!Clear)
            throw new TaskValidationException("--clear parameter is required.");
    }
  }
}
