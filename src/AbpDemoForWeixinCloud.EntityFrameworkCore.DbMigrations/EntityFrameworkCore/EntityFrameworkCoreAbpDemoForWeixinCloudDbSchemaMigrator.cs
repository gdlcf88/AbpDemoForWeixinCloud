using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpDemoForWeixinCloud.Data;
using Volo.Abp.DependencyInjection;

namespace AbpDemoForWeixinCloud.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpDemoForWeixinCloudDbSchemaMigrator
        : IAbpDemoForWeixinCloudDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpDemoForWeixinCloudDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpDemoForWeixinCloudMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpDemoForWeixinCloudMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}