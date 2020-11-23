using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace PracticeProject.Forum.TestTool
{
    /// <summary>
    /// 测试实体/聚合根
    /// </summary>
    public class TestTool : FullAuditedAggregateRoot<Guid>
    {
        public TestTool(string value)
        {
            this.Value = value;
        }

        [NotNull]
        public string Value { get; set; }
    }
}