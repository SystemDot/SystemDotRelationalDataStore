using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.Bootstrapping
{
    public class RelationalDataStoreBootstrapBuilderConfiguration
    {
        readonly BootstrapBuilderConfiguration config;

        public RelationalDataStoreBootstrapBuilderConfiguration(BootstrapBuilderConfiguration config)
        {
            this.config = config;
        }

        public BootstrapBuilderConfiguration GetBootstrapBuilderConfiguration()
        {
            return config;
        }
    }
}