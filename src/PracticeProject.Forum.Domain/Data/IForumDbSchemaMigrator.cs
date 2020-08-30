using System.Threading.Tasks;

namespace PracticeProject.Forum.Data
{
    public interface IForumDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
