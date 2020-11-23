using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Forum.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试仓储
    /// </summary>
    public class TestToolRepository : EfCoreRepository<ForumDbContext, TestTool>, ITestToolRepository
    {
        public TestToolRepository(IDbContextProvider<ForumDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<TestTool> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task<TestTool> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据id查询value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<string> GetValueById(Guid id)
        {
            return DbContext.TestTool.Where(q => q.Id == id).Select(q=>q.Value).FirstOrDefaultAsync();

        }
    }
}