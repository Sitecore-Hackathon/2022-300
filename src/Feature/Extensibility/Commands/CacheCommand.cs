using Hackathon.CLI.Feature.Extensibility.Caching.Tasks;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System;
using System.CommandLine;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Commands
{
    [ExcludeFromCodeCoverage]
  public class CacheCommand : SubcommandBase<ClearCacheTask, CacheArgs>
  {
    public CacheCommand(IServiceProvider container)
      : base("cache", "Sitecore Cache commands", container)
    {
        ((Command) this).AddOption(ArgOptions.Clear);
    }

    protected override async Task<int> Handle(ClearCacheTask task, CacheArgs args)
    {
        task.Execute((ClearCacheTaskOptions)args);
        return 0;
    }
  }
}
