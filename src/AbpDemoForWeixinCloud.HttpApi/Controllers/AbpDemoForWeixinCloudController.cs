using AbpDemoForWeixinCloud.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemoForWeixinCloud.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpDemoForWeixinCloudController : AbpController
    {
        protected AbpDemoForWeixinCloudController()
        {
            LocalizationResource = typeof(AbpDemoForWeixinCloudResource);
        }
    }
}