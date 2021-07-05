using AbpDemoForWeixinCloud.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpDemoForWeixinCloud.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpDemoForWeixinCloudPageModel : AbpPageModel
    {
        protected AbpDemoForWeixinCloudPageModel()
        {
            LocalizationResourceType = typeof(AbpDemoForWeixinCloudResource);
        }
    }
}