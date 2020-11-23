using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    public static class ForumDbContextModelCreatingExtensions
    {
        public static void ConfigureForum(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* 在此处配置您自己的表/实体 */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ForumConsts.DbTablePrefix + "YourEntities", ForumConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<TestTool.TestTool>(b =>
            {
                b.ToTable(ForumConsts.DbTablePrefix + "TestTool", ForumConsts.TestDbSchema);
                b.ConfigureByConvention();

                b.Property(_ => _.Value).IsRequired().HasMaxLength(1000);
            });
        }
    }
}