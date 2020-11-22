using System;
using System.Collections.Generic;
using System.Text;
using PracticeProject.Forum.Localization;
using Volo.Abp.Application.Services;

namespace PracticeProject.Forum
{
    /* 从此类继承您的应用程序服务。
     */

    public abstract class ForumAppService : ApplicationService
    {
        protected ForumAppService()
        {
            LocalizationResource = typeof(ForumResource);
        }
    }
}