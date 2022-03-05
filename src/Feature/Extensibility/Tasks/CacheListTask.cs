using Microsoft.Extensions.Logging;
using Sitecore.DevEx.Client.Logging;
using Sitecore.DevEx.Configuration.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Tasks
{
    public class CacheListTask
  {
    private readonly ILogger<CacheListTask> _logger;
    //private readonly IIndexListService _indexListService;
    private readonly IEnvironmentConfigurationProvider _configurationProvider;

    public CacheListTask(
      //IIndexListService indexListService,
      ILogger<CacheListTask> logger,
      IEnvironmentConfigurationProvider configurationProvider)
    {
      //this._indexListService = indexListService;
      this._logger = logger;
      this._configurationProvider = configurationProvider;
    }

    public async Task Execute(CacheTaskOptions args)
    {
      EnvironmentConfiguration configurationAsync = await this._configurationProvider.GetEnvironmentConfigurationAsync(args.Config, args.EnvironmentName);
      Stopwatch stopwatch = Stopwatch.StartNew();
      //List<string> list = (await this._indexListService.GetIndexListAsync(configurationAsync).ConfigureAwait(false)).ToList<string>();
      this._logger.LogTrace(string.Format("Indexes: Loaded in {0}ms ({1} indexes).", (object) stopwatch.ElapsedMilliseconds, (object) 0));
      ColorLogExtensions.LogConsoleInformation((ILogger) this._logger, "Indexes list:", new ConsoleColor?(ConsoleColor.Yellow), new ConsoleColor?());
      //foreach (string str in list)
      //  ColorLogExtensions.LogConsoleInformation((ILogger) this._logger, str, new ConsoleColor?(ConsoleColor.Green), new ConsoleColor?());
      stopwatch = (Stopwatch) null;
    }
  }
}
