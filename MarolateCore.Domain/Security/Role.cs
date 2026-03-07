using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Domain.Security
{
    /// <summary>
    /// Represents a role in the system used for authorization.
    /// نمایانگر یک نقش در سیستم برای کنترل دسترسی کاربران.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Unique identifier of the role.
        /// شناسه یکتای نقش در سیستم.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the role (e.g., Admin, Accountant).
        /// نام نقش مانند مدیر سیستم یا حسابدار.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Permissions assigned to this role.
        /// مجموعه مجوزهایی که به این نقش اختصاص داده شده‌اند.
        /// </summary>
        public ICollection<RolePermission> Permissions { get; private set; }

        private Role() { }

        /// <summary>
        /// Creates a new role.
        /// ایجاد یک نقش جدید در سیستم.
        /// </summary>
        public Role(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Permissions = new List<RolePermission>();
        }
    }
}
