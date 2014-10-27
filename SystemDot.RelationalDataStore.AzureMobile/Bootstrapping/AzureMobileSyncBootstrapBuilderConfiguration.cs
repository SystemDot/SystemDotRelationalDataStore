using System;
using SystemDot.AzureMobile;
using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    public class AzureMobileSyncBootstrapBuilderConfiguration
    {
        readonly BootstrapBuilderConfiguration bootstrapBuilderConfiguration;
        readonly string dbFileName;
        readonly Action<TableDefiner> tableDefinitions;

        public AzureMobileSyncBootstrapBuilderConfiguration(
            BootstrapBuilderConfiguration bootstrapBuilderConfiguration, 
            string dbFileName, 
            Action<TableDefiner> tableDefinitions)
        {
            this.bootstrapBuilderConfiguration = bootstrapBuilderConfiguration;
            this.dbFileName = dbFileName;
            this.tableDefinitions = tableDefinitions;
        }

        public AzureMobileSyncLicenceKeyBootstrapBuilderConfiguration SyncUpTo(string azureServerUrl)
        {
            return new AzureMobileSyncLicenceKeyBootstrapBuilderConfiguration(
                bootstrapBuilderConfiguration, 
                dbFileName,
                tableDefinitions,
                azureServerUrl);
        }
    }
}