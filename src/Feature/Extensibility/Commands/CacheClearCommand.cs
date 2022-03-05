using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.Client.Tasks;
using Hackathon.CLI.Feature.Extensibility.Caching.Tasks;
using System;
using System.Threading.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Commands
{
    public class CacheClearCommand : SubcommandBase<CacheListTask, CacheTaskOptions>
  {
    public CacheClearCommand(IServiceProvider container)
      : base("clear", "clears cache", container)
    {
      
    }

    protected override async Task<int> Handle(CacheListTask task, CacheTaskOptions args)
    {
        ((TaskOptionsBase)args).Validate();
        await task.Execute(args).ConfigureAwait(false);
        return 0;
    }
  }
}
