using Hackathon.CLI.Feature.Cache.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Sitecore.DevEx.Client.Logging;
using Sitecore.DevEx.Client.Tasks;
using Sitecore.DevEx.Configuration;
using System;
using System.Diagnostics;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Tasks
{
    public class ClearCacheTask
  {
    private readonly IRootConfigurationManager _rootConfigurationManager;
    private readonly ILoggerFactory _loggerFactory;
    private readonly ILogger _logger;
    private readonly ICachingService _cachingService;

        public ClearCacheTask(
      IRootConfigurationManager rootConfigurationManager,
      ILoggerFactory loggerFactory,
      ICachingService cachingService)
    {
      this._rootConfigurationManager = rootConfigurationManager ?? throw new ArgumentNullException(nameof (rootConfigurationManager));
      this._loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof (loggerFactory));
      this._logger = (ILogger) loggerFactory.CreateLogger<ClearCacheTask>();
      _cachingService = cachingService;
    }

    public async void Execute(ClearCacheTaskOptions options)
    {
        ((TaskOptionsBase) options).Validate();
        Stopwatch outerStopwatch = Stopwatch.StartNew();

        this._cachingService.Process();

        outerStopwatch.Stop();
        ColorLogExtensions.LogConsoleVerbose(this._logger, string.Empty, new ConsoleColor?(), new ConsoleColor?());
        ColorLogExtensions.LogConsoleVerbose(this._logger, string.Format("Cache cleared in {0}ms.", (object) outerStopwatch.ElapsedMilliseconds), new ConsoleColor?(), new ConsoleColor?());
        outerStopwatch = (Stopwatch) null;
    }
  }
}
