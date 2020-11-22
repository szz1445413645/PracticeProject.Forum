using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    /* 此DbContext仅用于数据库迁移。
     * 在运行时不使用它。 有关运行时DbContext，请参见ForumDbContext。
     * 它是一个统一的模型，其中包括所有使用的模块和您的应用程序的配置。
     */

    public class ForumMigrationsDbContext : AbpDbContext<ForumMigrationsDbContext>
    {
        public ForumMigrationsDbContext(DbContextOptions<ForumMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* 将模块包含到您的迁移数据库上下文中 */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* 在ConfigureForum方法中配置自己的表/实体 */

            builder.ConfigureForum();
        }
    }
}