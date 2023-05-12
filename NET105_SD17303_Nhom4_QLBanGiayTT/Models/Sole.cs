namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Sole
    {
        public Guid SoleID { get; set; }
        public string? Name { get; set; }
        public string? Fabric { get; set; }//Chất liệu
        public int Height { get; set; }
        public int Status { get; set; }
        public virtual List<ShoesDetails> ShoesDetails { get; set; }
    }
}
