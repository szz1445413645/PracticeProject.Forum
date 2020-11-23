using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace PracticeProject.Forum.Users
{
    /* 该实体与Identity模块的IdentityUser实体共享相同的表/集合（默认情况下为“ AbpUsers”）。
     *
     * - 您可以在此类中定义自定义属性。
     * - 您永远不会创建或删除该实体，因为它是Identity模块的工作。
     * - 您可以使用该实体从数据库中查询用户。
     * - 您可以更新自定义属性的值。
     */

    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        #region Base properties

        /* 这些属性与Identity模块的IdentityUser实体共享。
         * Do not change these properties through this class. Instead, use Identity module
         * services (like IdentityUserManager) to change them.
         * So, this properties are designed as read only!
         */

        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }

        #endregion Base properties

        /* 在此处添加您自己的属性。 例如:
         *
         * public string MyProperty { get; set; }
         *
         * 如果添加属性并使用EF Core，请记住以下内容；
         *
         * 1. 更新 ForumDbContext.OnModelCreating 配置新属性的映射
         * 2. 更新ForumEfCoreEntityExtensionMappings以扩展IdentityUser实体，
         * 并将新属性添加到迁移中。
         * 3. 使用“Add-Migration”来添加新的数据库迁移。
         * 4. Run the .DbMigrator project (or use the Update-Database command) to apply
         * schema change to the database.
         */

        private AppUser()
        {
        }
    }
}