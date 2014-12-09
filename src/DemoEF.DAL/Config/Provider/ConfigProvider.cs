
namespace DemoEF.DAL.Config.Provider
{
    public class ConfigProvider : System.Data.Entity.DbConfiguration
    {
        public ConfigProvider()
        {

            SetProviderServices(
                           System.Data.Entity.SqlServer.SqlProviderServices.ProviderInvariantName,
                           System.Data.Entity.SqlServer.SqlProviderServices.Instance
                           );
        }
    }
}