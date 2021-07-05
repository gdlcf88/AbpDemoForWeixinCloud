using System;
using System.Collections.Generic;
using System.Text;
using AbpDemoForWeixinCloud.Localization;
using Volo.Abp.Application.Services;

namespace AbpDemoForWeixinCloud
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpDemoForWeixinCloudAppService : ApplicationService
    {
        protected AbpDemoForWeixinCloudAppService()
        {
            LocalizationResource = typeof(AbpDemoForWeixinCloudResource);
        }
    }
}
