using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");
            builder.HasKey(c => c.ImageID);
            builder.Property(c => c.Name).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Image1).HasColumnType("nvarchar(1000)");
            builder.Property(c => c.Image2).HasColumnType("nvarchar(1000)");
            builder.Property(c => c.Image3).HasColumnType("nvarchar(1000)");
            builder.Property(c => c.Image4).HasColumnType("nvarchar(1000)");
            builder.Property(c => c.Status).HasColumnType("int");
            builder.HasOne(c => c.ShoesDetails).WithMany(c => c.Images).HasForeignKey(c => c.ShoesDetailsID);
        }
    }
}
