using SystemDot.Bootstrapping;
using SystemDot.RelationalDataStore.Bootstrapping;

namespace SystemDot.RelationalDataStore.InMemory.Bootstrapping
{
    public static class RelationalDataStoreBootstrapBuilderConfigurationExtensions
    {
        public static BootstrapBuilderConfiguration PersistToMemory(this RelationalDataStoreBootstrapBuilderConfiguration config)
        {
            config.GetBootstrapBuilderConfiguration().RegisterBuildAction(c => c.RegisterInMemoryRelationalDataStore());

            return config.GetBootstrapBuilderConfiguration();
        }
    }
}
