using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpDemoForWeixinCloud.Pages
{
    public class Index_Tests : AbpDemoForWeixinCloudWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
