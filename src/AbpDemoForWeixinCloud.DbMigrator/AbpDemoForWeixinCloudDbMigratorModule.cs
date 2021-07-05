using AbpDemoForWeixinCloud.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpDemoForWeixinCloud.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpDemoForWeixinCloudEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpDemoForWeixinCloudApplicationContractsModule)
        )]
    public class AbpDemoForWeixinCloudDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
