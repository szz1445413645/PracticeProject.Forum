using PracticeProject.Forum.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PracticeProject.Forum.Controllers
{
    /* 从此类继承您的控制器。
     */

    public abstract class ForumController : AbpController
    {
        protected ForumController()
        {
            LocalizationResource = typeof(ForumResource);
        }
    }
}