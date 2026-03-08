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
    /// Configures the database mapping for the Permission entity.
    /// پیکربندی نگاشت پایگاه داده برای موجودیت مجوز.
    /// </summary>
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        /// <summary>
        /// Configures permission properties and indexes.
        /// پیکربندی ویژگی‌ها و ایندکس‌های مجوز.
        /// </summary>
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasIndex(x => x.Name)
                   .IsUnique();
        }
    }
}
