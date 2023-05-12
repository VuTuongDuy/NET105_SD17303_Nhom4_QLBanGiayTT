namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Voucher
    {
        public Guid VoucherID { get; set; }
        public string? VoucherCode { get; set; }
        public decimal VoucherValue { get; set; }
        public int MaxUsage { get; set; }
        public int RemainingUsage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Status { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
