using System.Threading.Tasks;

namespace AbpDemoForWeixinCloud.Data
{
    public interface IAbpDemoForWeixinCloudDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
