using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试仓储接口
    /// </summary>
    public interface ITestToolRepository : IRepository<TestTool, Guid>
    {
        /// <summary>
        /// 根据id获取value
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        Task<string> GetValueById(Guid id);
    }
}