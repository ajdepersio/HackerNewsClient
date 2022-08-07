using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajd.HackerNewsClient.Core.Factories;
using Ajd.HackerNewsClient.Core.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Ajd.HackerNewsClient.Core.Client
{
    internal class HackerNewsClient : IHackerNewsClient
    {
        private readonly ILogger<IHackerNewsClient> _logger;

        public IItemService Items { get; }
        public ILiveDataService LiveData { get; }
        public IUserService Users { get; }

        public HackerNewsClient(IHackerNewsServiceFactory factory, ILogger<IHackerNewsClient>? logger = default)
        {
            _logger = logger ?? new NullLoggerFactory().CreateLogger<IHackerNewsClient>();

            try
            {
                Items = factory.CreateItemService();
                LiveData = factory.CreateLiveDataService();
                Users = factory.CreateUserService();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}
