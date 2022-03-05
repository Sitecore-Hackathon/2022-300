using System.CommandLine;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.CLI.Feature.Extensibility.Caching
{
    [ExcludeFromCodeCoverage]
  internal static class ArgOptions
  {
    internal static readonly Option Config = new Option(new string[2]
    {
      "--clear",
      "-c"
    }, "Clears cache");
  }
}
