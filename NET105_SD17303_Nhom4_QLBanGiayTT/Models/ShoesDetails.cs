﻿namespace NET105_SD17303_Nhom4_QLBanGiayTT.Models
{
    public class ShoesDetails
    {
        public Guid ShoesDetailsId { get; set; }
        public decimal Price { get; set; }
        public decimal ImportPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
        public Guid? ColorID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? SizeID { get; set; }
        public Guid? SoleID { get; set; }
        public Guid? StyleID { get; set; }
        public Guid? SupplierID { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
        public virtual Sole Sole { get; set; }
        public virtual Product Product { get; set; }
        public virtual Style Style { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<CartDetails> CartDetails { get; set; }
    }
}
