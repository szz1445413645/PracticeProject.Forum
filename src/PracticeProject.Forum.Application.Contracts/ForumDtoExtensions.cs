using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace PracticeProject.Forum
{
    public static class ForumDtoExtensions
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                /* 您可以将扩展属性添加到从属模块中定义的DTO。
                 *
                 * 例：
                 *
                 * ObjectExtensionManager.Instance
                 *   .AddOrUpdateProperty<IdentityRoleDto, string>("Title");
                 *
                 * 有关更多信息，请参见文档：
                 * https://docs.abp.io/en/abp/latest/Object-Extensions
                 */
            });
        }
    }
}