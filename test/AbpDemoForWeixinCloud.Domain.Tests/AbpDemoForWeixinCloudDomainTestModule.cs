using AbpDemoForWeixinCloud.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDemoForWeixinCloud
{
    [DependsOn(
        typeof(AbpDemoForWeixinCloudEntityFrameworkCoreTestModule)
        )]
    public class AbpDemoForWeixinCloudDomainTestModule : AbpModule
    {

    }
}