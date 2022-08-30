using Ajd.HackerNewsClient.Console;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddHostedService<HackerNewsClientService>()
    )
    .Build();

await host.RunAsync();
