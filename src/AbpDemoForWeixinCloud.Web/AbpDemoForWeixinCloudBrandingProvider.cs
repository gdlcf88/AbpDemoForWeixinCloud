﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpDemoForWeixinCloud.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpDemoForWeixinCloudBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpDemoForWeixinCloud";
    }
}
