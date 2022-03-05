using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Hackathon.CLI.Feature.Extensibility.Caching.Commands;
using Sitecore.DevEx.Serialization.Client;
using System;
using System.Collections.Generic;

namespace Hackathon.CLI.Feature.Extensibility.Caching
{
  public class RegisterExtension : ISitecoreCliExtension
  {
    public IEnumerable<ISubcommand> AddCommands(IServiceProvider container) => (IEnumerable<ISubcommand>) new ISubcommand[1]
    {
      (ISubcommand) container.GetRequiredService<CacheCommand>()
    };

    public void AddConfiguration(IConfigurationBuilder configBuilder)
    {
    }

    public void AddServices(IServiceCollection serviceCollection) => serviceCollection.AddSerialization().AddSingleton<CacheCommand>();
  }
}
