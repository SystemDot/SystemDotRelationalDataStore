using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.Bootstrapping
{
    public static class BootstrapBuilderConfigurationExtensions
    {
        public static RelationalDataStoreBootstrapBuilderConfiguration UseRelationalDataStore(this BootstrapBuilderConfiguration config)
        {
            return new RelationalDataStoreBootstrapBuilderConfiguration(config);
        }
    }
}