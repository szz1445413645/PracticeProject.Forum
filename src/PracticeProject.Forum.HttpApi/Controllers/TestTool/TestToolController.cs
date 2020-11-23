using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Forum.Localization;
using PracticeProject.Forum.TestTool;
using Volo.Abp.AspNetCore.Mvc;

namespace PracticeProject.Forum.Controllers.TestTool
{
    /// <summary>
    /// 测试控制器
    /// </summary>
    public class TestToolController : ForumController
    {

        private ITestToolAppService _testToolAppService;

        public TestToolController(ITestToolAppService testToolAppService)
        {
            _testToolAppService = testToolAppService;
        }

        [HttpGet]
        public async Task<string> GetText()
        {
            string result = await _testToolAppService.GetValueById(new Guid(".."));
            
            return result ?? " ";
        }

        [HttpGet]
        [Authorize]
        public async Task<string> GetText2()
        {
            return await _testToolAppService.GetValueById(new Guid());
        }

        [HttpGet]
        public string GetText3()
        {
            return "test3";
        }
    }
}