using Ajd.HackerNewsClient.Core.Services;

namespace Ajd.HackerNewsClient.Core.Factories
{
    internal interface IHackerNewsServiceFactory
    {
        IItemService CreateItemService();
        ILiveDataService CreateLiveDataService();
        IUserService CreateUserService();
    }
}
