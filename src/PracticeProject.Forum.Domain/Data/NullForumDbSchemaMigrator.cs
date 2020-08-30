using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PracticeProject.Forum.Data
{
    /* This is used if database provider does't define
     * IForumDbSchemaMigrator implementation.
     */
    public class NullForumDbSchemaMigrator : IForumDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}