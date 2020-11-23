using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试应用服务接口
    /// </summary>
    public interface ITestToolAppService:IApplicationService
    {
        Task<string> GetValueById(Guid id);
    }
}
