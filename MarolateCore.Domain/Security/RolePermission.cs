using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Domain.Security
{
    /// <summary>
    /// Represents the relationship between roles and permissions.
    /// نمایانگر رابطه بین نقش‌ها و مجوزها در سیستم.
    /// </summary>
    public class RolePermission
    {
        /// <summary>
        /// Identifier of the role.
        /// شناسه نقشی که این مجوز به آن اختصاص دارد.
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Identifier of the permission.
        /// شناسه مجوزی که به نقش داده شده است.
        /// </summary>
        public Guid PermissionId { get; set; }

        /// <summary>
        /// Navigation property to the role.
        /// ارتباط ناوبری به موجودیت نقش.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Navigation property to the permission.
        /// ارتباط ناوبری به موجودیت مجوز.
        /// </summary>
        public Permission Permission { get; set; }
    }
}
