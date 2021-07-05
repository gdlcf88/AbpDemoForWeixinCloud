using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpDemoForWeixinCloud.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpDemoForWeixinCloudEntityFrameworkCoreModule)
        )]
    public class AbpDemoForWeixinCloudEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpDemoForWeixinCloudMigrationsDbContext>();
        }
    }
}
