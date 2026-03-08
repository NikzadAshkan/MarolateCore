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
    /// Configures the relationship between roles and permissions.
    /// پیکربندی رابطه بین نقش‌ها و مجوزها.
    /// </summary>
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        /// <summary>
        /// Configures composite keys and relationships for role permissions.
        /// پیکربندی کلید ترکیبی و روابط برای مجوزهای نقش.
        /// </summary>
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("RolePermissions");

            builder.HasKey(x => new { x.RoleId, x.PermissionId });

            builder.HasOne(x => x.Role)
                   .WithMany(x => x.Permissions)
                   .HasForeignKey(x => x.RoleId);

            builder.HasOne(x => x.Permission)
                   .WithMany()
                   .HasForeignKey(x => x.PermissionId);
        }
    }
}
