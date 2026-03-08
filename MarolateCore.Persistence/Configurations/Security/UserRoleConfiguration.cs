using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Persistence.Configurations.Security
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MarolateCore.Domain.Security;

    /// <summary>
    /// Configures the relationship between users and roles.
    /// پیکربندی رابطه بین کاربران و نقش‌ها.
    /// </summary>
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        /// <summary>
        /// Configures composite keys and relationships for user roles.
        /// پیکربندی کلید ترکیبی و روابط برای نقش‌های کاربر.
        /// </summary>
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");

            builder.HasKey(x => new { x.UserId, x.RoleId });

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Roles)
                   .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Role)
                   .WithMany()
                   .HasForeignKey(x => x.RoleId);
        }
    }
}
