using System;
using System.Collections.Generic;
using System.Text;
using PracticeProject.Forum.Localization;
using Volo.Abp.Application.Services;

namespace PracticeProject.Forum
{
    /* Inherit your application services from this class.
     */
    public abstract class ForumAppService : ApplicationService
    {
        protected ForumAppService()
        {
            LocalizationResource = typeof(ForumResource);
        }
    }
}
