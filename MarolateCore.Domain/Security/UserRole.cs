using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Domain.Security
{
    /// <summary>
    /// Represents the relationship between users and roles.
    /// نمایانگر رابطه بین کاربران و نقش‌ها در سیستم.
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// Identifier of the user.
        /// شناسه کاربری که این نقش به او تعلق دارد.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Identifier of the role.
        /// شناسه نقشی که به کاربر اختصاص داده شده است.
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Navigation property to the user.
        /// ارتباط ناوبری به موجودیت کاربر.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Navigation property to the role.
        /// ارتباط ناوبری به موجودیت نقش.
        /// </summary>
        public Role Role { get; set; }
    }
}
