using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PracticeProject.Forum.EntityFrameworkCore
{
    public static class ForumDbContextModelCreatingExtensions
    {
        public static void ConfigureForum(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ForumConsts.DbTablePrefix + "YourEntities", ForumConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}