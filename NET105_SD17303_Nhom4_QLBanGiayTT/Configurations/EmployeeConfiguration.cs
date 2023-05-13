using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_SD17303_Nhom4_QLBanGiayTT.Models;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(c => c.EmployeeID);
            builder.Property(c => c.FullName).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Password).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Email).HasColumnType("nvarchar(300)");
            builder.Property(c => c.Sex).HasColumnType("int");
            builder.Property(c => c.PhoneNumber).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Status).HasColumnType("int");
            builder.HasOne(c => c.Role).WithMany(c => c.Employees).HasForeignKey(c => c.RoleID);
        }
    }
}
