using SystemDot.RelationalDataStore.Bootstrapping;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    public static class RelationalDataStoreBootstrapBuilderConfigurationExtensions
    {
        public static AzureMobileBootstrapBuilderConfiguration PersistToAzureMobileDatabase(this RelationalDataStoreBootstrapBuilderConfiguration config)
        {
            return new AzureMobileBootstrapBuilderConfiguration(config.GetBootstrapBuilderConfiguration());
        }
    }
}
