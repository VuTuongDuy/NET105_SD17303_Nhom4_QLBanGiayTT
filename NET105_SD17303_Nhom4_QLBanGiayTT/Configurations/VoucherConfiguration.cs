using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");
            builder.HasKey(c => c.VoucherID);
            builder.Property(c => c.VoucherCode).HasColumnType("nvarchar(100)");
            builder.Property(c => c.VoucherValue).HasColumnType("decimal(18, 2)");
            builder.Property(c => c.ExpirationDate).HasColumnType("Datetime");
            builder.Property(c => c.MaxUsage).HasColumnType("int");
            builder.Property(c => c.RemainingUsage).HasColumnType("int");
            builder.Property(c => c.Status).HasColumnType("int");
        }
    }
}
