using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System.CommandLine;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Commands
{
  public class CacheCommand : Command, ISubcommand
  {
    public CacheCommand(string name, string description = null)
      : base(name, description)
    {
    }
  }
}
