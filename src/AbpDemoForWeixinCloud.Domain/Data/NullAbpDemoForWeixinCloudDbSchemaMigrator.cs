using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpDemoForWeixinCloud.Data
{
    /* This is used if database provider does't define
     * IAbpDemoForWeixinCloudDbSchemaMigrator implementation.
     */
    public class NullAbpDemoForWeixinCloudDbSchemaMigrator : IAbpDemoForWeixinCloudDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}