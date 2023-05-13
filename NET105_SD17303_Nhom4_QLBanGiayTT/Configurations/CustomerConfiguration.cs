﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c => c.CumstomerID);
            builder.Property(c => c.UserName).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Password).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Email).HasColumnType("nvarchar(300)");
            builder.Property(c => c.Sex).HasColumnType("int");
            builder.Property(c => c.Address).HasColumnType("nvarchar(400)");
            builder.Property(c => c.PhoneNumber).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Status).HasColumnType("int");
            builder.HasOne(c => c.Cart).WithOne(c => c.Customer).HasForeignKey<Cart>(c => c.CumstomerID);
        }
    }
}
