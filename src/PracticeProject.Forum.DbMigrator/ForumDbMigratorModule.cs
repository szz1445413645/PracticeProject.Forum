using PracticeProject.Forum.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PracticeProject.Forum.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ForumEntityFrameworkCoreDbMigrationsModule),
        typeof(ForumApplicationContractsModule)
        )]
    public class ForumDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
