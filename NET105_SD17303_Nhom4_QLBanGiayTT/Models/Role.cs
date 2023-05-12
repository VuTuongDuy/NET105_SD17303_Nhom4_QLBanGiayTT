namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Role
    {
        public Guid RoleID { get; set; }
        public string? RoleName { get; set; }
        public int Status { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
