namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Bill
    {
        public Guid BillID { get; set; }
        public string BillCode { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime SuccessDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CancelDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingCosts { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public Guid CouponID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid VoucherID { get; set; }
        public Guid EmployeeID { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<BillDetails> BillDetails { get; set; }
    }
}
