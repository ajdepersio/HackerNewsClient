using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajd.HackerNewsClient.Core.Services;

namespace Ajd.HackerNewsClient.Core.Factories
{
    class HackerNewsServiceFactory : IHackerNewsServiceFactory
    {
        public IItemService CreateItemService() => throw new NotImplementedException();
        public ILiveDataService CreateLiveDataService() => throw new NotImplementedException();
        public IUserService CreateUserService() => throw new NotImplementedException();
    }
}
