namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Cart
    {
        public Guid CumstomerID { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<CartDetails> CartDetails { get; set; }
    }
}
