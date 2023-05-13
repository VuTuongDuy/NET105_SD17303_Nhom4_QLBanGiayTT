using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class SoleConfiguration : IEntityTypeConfiguration<Sole>
    {
        public void Configure(EntityTypeBuilder<Sole> builder)
        {
            builder.ToTable("Sole");
            builder.HasKey(c => c.SoleID);
            builder.Property(c => c.Name).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Fabric).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Height).HasColumnType("decimal(18, 2)");
            builder.Property(c => c.Status).HasColumnType("int");
        }
    }
}
