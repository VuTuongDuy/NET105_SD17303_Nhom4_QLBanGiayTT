namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Size
    {
        public Guid SizeID { get; set; }
        public string? Name { get; set; }
        public int Status { get; set; }
        public virtual List<ShoesDetails> ShoesDetails { get; set; }
    }
}
