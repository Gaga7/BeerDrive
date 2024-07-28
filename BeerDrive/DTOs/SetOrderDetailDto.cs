using System;

namespace BeerDrive.DTOs
{
    public class SetOrderDetailDto
    {
        public Guid? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Discount { get; set; }
    }
}
