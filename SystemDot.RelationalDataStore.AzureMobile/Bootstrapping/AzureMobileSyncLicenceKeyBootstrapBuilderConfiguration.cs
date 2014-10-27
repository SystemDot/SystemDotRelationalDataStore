using System;
using SystemDot.AzureMobile;
using SystemDot.Bootstrapping;

namespace SystemDot.RelationalDataStore.AzureMobile.Bootstrapping
{
    public class AzureMobileSyncLicenceKeyBootstrapBuilderConfiguration
    {
        readonly BootstrapBuilderConfiguration bootstrapBuilderConfiguration;
        readonly string dbFileName;
        readonly Action<TableDefiner> tableDefinitions;
        readonly string azureServerUrl;

        public AzureMobileSyncLicenceKeyBootstrapBuilderConfiguration(
            BootstrapBuilderConfiguration bootstrapBuilderConfiguration, 
            string dbFileName, 
            Action<TableDefiner> tableDefinitions, 
            string azureServerUrl)
        {
            this.bootstrapBuilderConfiguration = bootstrapBuilderConfiguration;
            this.dbFileName = dbFileName;
            this.tableDefinitions = tableDefinitions;
            this.azureServerUrl = azureServerUrl;
        }

        public BootstrapBuilderConfiguration WithLicenceKey(string licenceKey)
        {
            bootstrapBuilderConfiguration.RegisterBuildAction(c => c.RegisterAzureMobileRelationalDataStore());
        
            return bootstrapBuilderConfiguration.RegisterBuildAction(
                async c => await 
                    c.Resolve<DataContextLookup>()
                        .InitialiseAndAddAsync(
                            azureServerUrl, 
                            licenceKey, 
                            dbFileName, 
                            tableDefinitions), BuildOrder.VeryLate);
        }
    }
}