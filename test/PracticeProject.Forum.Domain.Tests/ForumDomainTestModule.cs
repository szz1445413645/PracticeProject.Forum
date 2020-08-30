using PracticeProject.Forum.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PracticeProject.Forum
{
    [DependsOn(
        typeof(ForumEntityFrameworkCoreTestModule)
        )]
    public class ForumDomainTestModule : AbpModule
    {

    }
}