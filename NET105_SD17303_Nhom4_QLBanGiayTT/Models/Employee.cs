﻿namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int Sex { get; set; }
        public string? PhoneNumber { get; set; }
        public int Status { get; set; }
        public Guid RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
