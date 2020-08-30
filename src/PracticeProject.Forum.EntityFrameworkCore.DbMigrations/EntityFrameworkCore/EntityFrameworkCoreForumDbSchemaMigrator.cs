using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PracticeProject.Forum.Data;
using Volo.Abp.DependencyInjection;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    public class EntityFrameworkCoreForumDbSchemaMigrator
        : IForumDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreForumDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ForumMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ForumMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}