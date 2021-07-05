using Volo.Abp.Settings;

namespace AbpDemoForWeixinCloud.Settings
{
    public class AbpDemoForWeixinCloudSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpDemoForWeixinCloudSettings.MySetting1));
        }
    }
}
