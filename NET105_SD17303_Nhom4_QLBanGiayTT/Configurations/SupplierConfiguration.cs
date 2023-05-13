using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(c => c.SupplierID);
            builder.Property(c => c.Name).HasColumnType("nvarchar(200)");
            builder.Property(c => c.Status).HasColumnType("int");
        }
    }
}
