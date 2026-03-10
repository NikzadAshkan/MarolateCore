using MarolateCore.Domain.Security;
using Microsoft.EntityFrameworkCore;

namespace MarolateCore.Persistence.DbContext
{
    public class MarolateCoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MarolateCoreDbContext(DbContextOptions<MarolateCoreDbContext> options)
            : base(options)
        {
        }

        // نمایانگر جدول کاربران در پایگاه داده.
        public DbSet<User> Users { get; set; }

        // نمایانگر جدول نقش‌ها در پایگاه داده.
                public DbSet<Role> Roles { get; set; }

        // نمایانگر جدول مجوزها در پایگاه داده.
        public DbSet<Permission> Permissions { get; set; }

        // نمایانگر ارتباط بین کاربران و نقش‌ها.
        public DbSet<UserRole> UserRoles { get; set; }

        // نمایانگر ارتباط بین نقش‌ها و مجوزها.
        public DbSet<RolePermission> RolePermissions { get; set; }

        // فعلاً DbSet نداریم (بعداً در Phase Entity Design اضافه می‌شود)

        /// <summary>
        /// Configures entity mappings using Fluent API.
        /// پیکربندی نگاشت موجودیت‌ها با استفاده از Fluent API.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarolateCoreDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }

}
