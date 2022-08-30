using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Ajd.HackerNewsClient.Console
{
    internal class HackerNewsClientService : IHostedService
    {
        private readonly ILogger _logger;

        public HackerNewsClientService(
            ILogger<HackerNewsClientService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("1. StartAsync has been called.");

            MainMenu();

            return Task.CompletedTask;
        }

        private void MainMenu()
        {
            System.Console.WriteLine("Main Menu");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("4. StopAsync has been called.");

            return Task.CompletedTask;
        }
    }
}
