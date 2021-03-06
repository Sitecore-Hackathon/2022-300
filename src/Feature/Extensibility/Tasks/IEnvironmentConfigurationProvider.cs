using Sitecore.DevEx.Configuration.Models;
using System.Threading.Tasks;

namespace Hackathon.CLI.Feature.Extensibility.Caching.Tasks
{
  public interface IEnvironmentConfigurationProvider
  {
    Task<EnvironmentConfiguration> GetEnvironmentConfigurationAsync(
      string currentDirectory,
      string environmentName);
  }
}
