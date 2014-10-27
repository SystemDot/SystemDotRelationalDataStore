using SystemDot.Ioc;
using SystemDot.RelationalDataStore.Repositories;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    internal static class IocContainerExtensions
    {
        internal static void RegisterAzureMobileRelationalDataStore(this IIocContainer container)
        {
            container.RegisterInstance<IRepository, Repository>();
        }
    }
}