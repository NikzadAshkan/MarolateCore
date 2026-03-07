using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Domain.Security
{
    /// <summary>
    /// Represents a system user who can access the application.
    /// نمایانگر یک کاربر در سیستم که می‌تواند به برنامه دسترسی داشته باشد.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier of the user.
        /// شناسه یکتای کاربر در سیستم.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// The username used for login.
        /// نام کاربری که برای ورود به سیستم استفاده می‌شود.
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Email address of the user.
        /// آدرس ایمیل کاربر.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Hashed password stored securely.
        /// رمز عبور هش شده که به صورت امن در سیستم ذخیره می‌شود.
        /// </summary>
        public string PasswordHash { get; private set; }

        /// <summary>
        /// Collection of roles assigned to the user.
        /// مجموعه نقش‌هایی که به کاربر اختصاص داده شده‌اند.
        /// </summary>
        public ICollection<UserRole> Roles { get; private set; }

        private User() { }

        /// <summary>
        /// Creates a new user instance.
        /// ایجاد یک کاربر جدید در سیستم.
        /// </summary>
        public User(string userName, string email, string passwordHash)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Email = email;
            PasswordHash = passwordHash;
            Roles = new List<UserRole>();
        }
    }
}
