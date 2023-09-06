﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Udemy.Bank.App.Web.Data.Entities;

namespace Udemy.Bank.App.Web.Data.Configurations
{
    public class ApplicationUserConfigruation : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Surname).HasMaxLength(100);
            builder.Property(x => x.Surname).IsRequired();

            builder.HasMany(x => x.Accounts).WithOne(x => x.ApplicationUser).HasForeignKey(x => x.ApplicationUserId);
        }
    }
}
