namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Customer
    {
        public Guid CumstomerID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int Sex { get; set; }
        public string? PhoneNumber { get; set; }
        public int Status { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
