using System;

namespace BeerDrive.DTOs
{
    public class GetOrderDetailDto
    {
        public Guid Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public Guid? ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Discount { get; set; }
        public string Supplier { get; set; }
        public string SupplierContactName { get; set; }
        public string SupplierContactMobile { get; set; }
        public string UserFullName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
