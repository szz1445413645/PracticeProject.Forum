using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    [DependsOn(
        typeof(ForumEntityFrameworkCoreModule)
        )]
    public class ForumEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ForumMigrationsDbContext>();
        }
    }
}
