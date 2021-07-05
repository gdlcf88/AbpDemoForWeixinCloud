using Volo.Abp.Modularity;

namespace AbpDemoForWeixinCloud
{
    [DependsOn(
        typeof(AbpDemoForWeixinCloudApplicationModule),
        typeof(AbpDemoForWeixinCloudDomainTestModule)
        )]
    public class AbpDemoForWeixinCloudApplicationTestModule : AbpModule
    {

    }
}