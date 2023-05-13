using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class ShopDBContext:DbContext
    {
        public ShopDBContext()
        {

        }
        public ShopDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoesDetails> ShoesDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Sole> Soles { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-46F72MJA\SQLEXPRESS;Initial Catalog=NET105_Nhom4_QLBanGiayTT;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
