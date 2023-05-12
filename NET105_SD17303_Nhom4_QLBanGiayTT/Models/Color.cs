namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Color
    {
        public Guid ColorID { get; set; }
        public string? Name { get; set; }
        public int Status { get; set; }
        public virtual List<ShoesDetails> ShoesDetails { get; set; }
    }
}
