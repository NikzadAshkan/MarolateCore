using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Domain.Security
{
    /// <summary>
    /// Represents a specific permission that controls access to system features.
    /// نمایانگر یک مجوز مشخص برای کنترل دسترسی به قابلیت‌های سیستم.
    /// </summary>
    public class Permission
    {
        /// <summary>
        /// Unique identifier of the permission.
        /// شناسه یکتای مجوز در سیستم.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the permission (e.g., inventory.create, accounting.post).
        /// نام مجوز مانند ایجاد موجودی یا ثبت سند حسابداری.
        /// </summary>
        public string Name { get; private set; }

        private Permission() { }

        /// <summary>
        /// Creates a new permission.
        /// ایجاد یک مجوز جدید در سیستم.
        /// </summary>
        public Permission(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
