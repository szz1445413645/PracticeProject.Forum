using PracticeProject.Forum.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PracticeProject.Forum.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ForumController : AbpController
    {
        protected ForumController()
        {
            LocalizationResource = typeof(ForumResource);
        }
    }
}