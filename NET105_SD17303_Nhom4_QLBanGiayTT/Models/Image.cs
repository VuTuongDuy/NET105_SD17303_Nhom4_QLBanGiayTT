namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Image
    {
        public Guid ImageID { get; set; }
        public string? Name { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public int Status { get; set; }
        public Guid? ShoesDetailsID { get; set; }
        public virtual ShoesDetails ShoesDetails { get; set; }
    }
}
