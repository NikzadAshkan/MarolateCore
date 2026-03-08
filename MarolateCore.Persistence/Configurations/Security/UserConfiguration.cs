using MarolateCore.Domain.Security;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarolateCore.Persistence.Configurations.Security
{
    /// <summary>
    /// Configures the database mapping for the User entity.
    /// پیکربندی نگاشت پایگاه داده برای موجودیت کاربر.
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        /// <summary>
        /// Configures entity properties, keys, and relationships.
        /// پیکربندی ویژگی‌ها، کلیدها و روابط موجودیت.
        /// </summary>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(x => x.UserName)
                   .IsUnique();

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasIndex(x => x.Email)
                   .IsUnique();

            builder.Property(x => x.PasswordHash)
                   .IsRequired();
        }
    }
}
