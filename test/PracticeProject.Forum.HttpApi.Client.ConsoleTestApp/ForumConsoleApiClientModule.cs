using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace PracticeProject.Forum.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ForumHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ForumConsoleApiClientModule : AbpModule
    {
        
    }
}
