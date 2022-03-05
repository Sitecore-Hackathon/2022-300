using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Hackathon.CLI.Feature.Extensibility.Caching.Commands;
using Hackathon.CLI.Feature.Extensibility.Caching.Tasks;
using Sitecore.DevEx.Serialization.Client;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.CLI.Feature.Extensibility.Caching
{
    public class RegisterExtension : ISitecoreCliExtension
  {
    public IEnumerable<ISubcommand> AddCommands(IServiceProvider container) => (IEnumerable<ISubcommand>) new ISubcommand[1]
    {
      RegisterExtension.CreateIndexCommand(container)
    };

    [ExcludeFromCodeCoverage]
    public void AddConfiguration(IConfigurationBuilder configBuilder)
    {
    }

    public void AddServices(IServiceCollection serviceCollection)
    {
      serviceCollection.AddSerialization().AddSingleton<CacheClearCommand>().AddSingleton<ILogger<CacheListTask>>((Func<IServiceProvider, ILogger<CacheListTask>>) (t => t.GetService<ILoggerFactory>().CreateLogger<CacheListTask>()));
      serviceCollection.TryAddTransient<ITreeSyncOperationExecutor, TreeSyncOperationExecutor>();
      serviceCollection.TryAddTransient<IEnvironmentConfigurationProvider, EnvironmentConfigurationProvider>();

    }

    private static ISubcommand CreateIndexCommand(IServiceProvider container)
    {
      CacheCommand indexesCommand = new CacheCommand("cache", "clear cache");
      //((Symbol) indexesCommand).AddAlias("index");
      indexesCommand.AddCommand((Command) container.GetRequiredService<CacheClearCommand>());
      return (ISubcommand) indexesCommand;
    }
  }
}
