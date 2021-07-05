using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpDemoForWeixinCloud.EntityFrameworkCore
{
    public static class AbpDemoForWeixinCloudDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpDemoForWeixinCloud(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpDemoForWeixinCloudConsts.DbTablePrefix + "YourEntities", AbpDemoForWeixinCloudConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}