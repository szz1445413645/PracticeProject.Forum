using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace PracticeProject.Forum.TestTool
{
    public class TestToolManager : DomainService, ITestToolManager
    {
        private ITestToolRepository _testToolRepository;

        public TestToolManager(ITestToolRepository testToolManager)
        {
            _testToolRepository = testToolManager;
        }

        public Task<string> GetValueById(Guid id)
        {
            return _testToolRepository.GetValueById(id);
        }
    }
}