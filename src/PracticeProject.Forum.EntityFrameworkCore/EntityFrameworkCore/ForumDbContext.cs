using Microsoft.EntityFrameworkCore;
using PracticeProject.Forum.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    /* 这是在运行时使用的实际 DbContext。
     * 它仅包含您的实体。
     * 它不包括所用模块的实体，因为每个模块已经具有自己的 DbContext 类。
     * 如果要与使用的模块共享一些数据库表，只需创建一个类似 AppUser 的结构即可。
     *
     * 不要将此 DbContext 用于数据库迁移，因为它不包含所用模块的表（如上所述）。
     * 有关迁移，请参见 ForumMigrationsDbContext。
     */

    [ConnectionStringName("Default")]
    public class ForumDbContext : AbpDbContext<ForumDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public DbSet<TestTool.TestTool> TestTool { get; set; }

        /* 在此处为您的聚合根/实体添加 DbSet 属性。
         * 还要在 ForumDbContextModelCreatingExtensions.ConfigureForum 中映射它们
         */

        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the ForumEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureForum method */

            builder.ConfigureForum();
        }
    }
}