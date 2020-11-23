using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试领域服务
    /// </summary>
    public interface ITestToolManager : IDomainService
    {
        Task<string> GetValueById(Guid id);
    }
}