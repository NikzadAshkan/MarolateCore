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
    /// Configures the database mapping for the Role entity.
    /// پیکربندی نگاشت پایگاه داده برای موجودیت نقش.
    /// </summary>
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        /// <summary>
        /// Configures role entity structure and constraints.
        /// پیکربندی ساختار و محدودیت‌های موجودیت نقش.
        /// </summary>
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                   .IsUnique();
        }
    }
}
