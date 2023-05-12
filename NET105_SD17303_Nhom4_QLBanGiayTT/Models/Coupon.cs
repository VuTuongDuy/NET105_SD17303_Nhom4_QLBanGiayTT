namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Coupon
    {
        public Guid CouponID { get; set; }
        public string? CouponCode { get; set; }
        public decimal CouponValue { get; set; }
        public int MaxUsage { get; set; }
        public int RemainingUsage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Status { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
