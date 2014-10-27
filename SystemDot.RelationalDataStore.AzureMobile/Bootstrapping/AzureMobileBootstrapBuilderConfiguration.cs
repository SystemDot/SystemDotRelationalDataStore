using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    public class AzureMobileBootstrapBuilderConfiguration
    {
        readonly BootstrapBuilderConfiguration bootstrapBuilderConfiguration;

        public AzureMobileBootstrapBuilderConfiguration(BootstrapBuilderConfiguration bootstrapBuilderConfiguration)
        {
            this.bootstrapBuilderConfiguration = bootstrapBuilderConfiguration;
        }

        public AzureMobileDatabaseBootstrapBuilderConfiguration UsingDatabaseFile(string fileName)
        {
            return new AzureMobileDatabaseBootstrapBuilderConfiguration(bootstrapBuilderConfiguration, fileName);
        }
    }
}