using Microsoft.AspNetCore.Mvc;
using PracticeProject.Forum.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PracticeProject.Forum.Controllers.TestTool
{
    /// <summary>
    /// 测试控制器
    /// </summary>
    public class TestToolController : ForumController
    {
        public TestToolController()
        {
        }

        [HttpGet]
        public string GetText()
        {
            return "test";
        }
    }
}