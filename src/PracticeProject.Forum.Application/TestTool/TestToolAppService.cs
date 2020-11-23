using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试应用服务
    /// </summary>
    public class TestToolAppService : ForumAppService,ITestToolAppService
    {
        private ITestToolManager _testToolManager;

        public TestToolAppService(ITestToolManager testToolManager)
        {
            _testToolManager = testToolManager;
        }

        public Task<string> GetValueById(Guid id)
        {
            return _testToolManager.GetValueById(id);
        }
    }
}