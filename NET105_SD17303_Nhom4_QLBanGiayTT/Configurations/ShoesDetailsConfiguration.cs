﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class ShoesDetailsConfiguration : IEntityTypeConfiguration<ShoesDetails>
    {
        public void Configure(EntityTypeBuilder<ShoesDetails> builder)
        {
            builder.ToTable("ShoesDetails");
            builder.HasKey(c => c.ShoesDetailsId);
            builder.Property(c => c.CreateDate).HasColumnType("Datetime");
            builder.Property(c => c.Price).HasColumnType("decimal(18, 2)");
            builder.Property(c => c.ImportPrice).HasColumnType("decimal(18, 2)");
            builder.Property(c => c.AvailableQuantity).HasColumnType("int");
            builder.Property(c => c.Description).HasColumnType("nvarchar(1000)");
            builder.Property(c => c.Status).HasColumnType("int");
            builder.HasOne(c => c.Size).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.SizeID);
            builder.HasOne(c => c.Sole).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.SoleID);
            builder.HasOne(c => c.Style).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.StyleID);
            builder.HasOne(c => c.Product).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.ProductID);
            builder.HasOne(c => c.Supplier).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.SupplierID);
            builder.HasOne(c => c.Color).WithMany(c => c.ShoesDetails).HasForeignKey(c => c.ColorID);
        }
    }
}
