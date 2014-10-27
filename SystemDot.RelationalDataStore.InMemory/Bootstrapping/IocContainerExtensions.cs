using SystemDot.Ioc;
using SystemDot.RelationalDataStore.Repositories;

namespace SystemDot.RelationalDataStore.InMemory.Bootstrapping
{
    internal static class IocContainerExtensions
    {
        internal static void RegisterInMemoryRelationalDataStore(this IIocContainer container)
        {
            container.RegisterInstance<IRepository, InMemoryRepository>();
        }
    }
}