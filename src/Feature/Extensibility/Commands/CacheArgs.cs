using Hackathon.CLI.Feature.Extensibility.Caching.Tasks;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Commands
{
[ExcludeFromCodeCoverage]
  public class CacheArgs : ClearCacheTaskOptions, IVerbosityArgs
  {
    public bool Verbose { get; set; }

    public bool Trace { get; set; }
  }
}
