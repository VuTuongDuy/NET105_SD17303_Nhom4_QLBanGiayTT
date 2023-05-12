namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class CartDetails
    {
        public Guid CartDetailsId { get; set; }
        public Guid CumstomerID { get; set; }
        public Guid ShoesDetailsId { get; set; }
        public int Quantity { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ShoesDetails ShoesDetails { get; set; }
    }
}
