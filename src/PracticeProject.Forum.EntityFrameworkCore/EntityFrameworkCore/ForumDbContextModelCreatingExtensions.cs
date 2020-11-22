using Microsoft.EntityFrameworkCore;
using Volo.Abp;

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
        }
    }
}