// Decompiled with JetBrains decompiler
// Type: Hackathon.CLI.Feature.Cache.Client.ContainerExtensions
// Assembly: Hackathon.CLI.Feature.Cache.Client, Version=4.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7390BF55-37E9-4858-A5AF-BCFA9A07C25F
// Assembly location: C:\Users\Paul.Vega\AppData\Local\Temp\Zegubot\272d79a503\plugin\Hackathon.CLI.Feature.Cache.Client.dll

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hackathon.CLI.Feature.Cache.Client.Services;
using System.Diagnostics.CodeAnalysis;

namespace Hackathon.CLI.Feature.Cache.Client
{
  [ExcludeFromCodeCoverage]
  public static class ContainerExtensions
  {
    public static IServiceCollection AddSchemaPopulation(
      this IServiceCollection serviceCollection)
    {
      serviceCollection.TryAddTransient<IClearCacheService, ClearCacheService>();
      return serviceCollection;
    }
  }
}
