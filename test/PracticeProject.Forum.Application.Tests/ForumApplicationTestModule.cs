using Volo.Abp.Modularity;

namespace PracticeProject.Forum
{
    [DependsOn(
        typeof(ForumApplicationModule),
        typeof(ForumDomainTestModule)
        )]
    public class ForumApplicationTestModule : AbpModule
    {

    }
}