using System;
using SystemDot.AzureMobile;
using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    public class AzureMobileDatabaseBootstrapBuilderConfiguration
    {
        readonly BootstrapBuilderConfiguration bootstrapBuilderConfiguration;
        readonly string fileName;

        public AzureMobileDatabaseBootstrapBuilderConfiguration(BootstrapBuilderConfiguration bootstrapBuilderConfiguration, string fileName)
        {
            this.bootstrapBuilderConfiguration = bootstrapBuilderConfiguration;
            this.fileName = fileName;
        }

        public AzureMobileSyncBootstrapBuilderConfiguration DefineTables(Action<TableDefiner> tableDefinitions)
        {
            return new AzureMobileSyncBootstrapBuilderConfiguration(bootstrapBuilderConfiguration, fileName, tableDefinitions);
        }
    }
}