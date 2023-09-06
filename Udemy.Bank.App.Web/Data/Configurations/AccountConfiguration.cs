using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Udemy.Bank.App.Web.Data.Entities;

namespace Udemy.Bank.App.Web.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.AccountNumber).IsRequired();

            builder.Property(X => X.Balance).HasColumnType("decimal(18,4)");
            builder.Property(x=>x.Balance).IsRequired();


        }
    }
}
