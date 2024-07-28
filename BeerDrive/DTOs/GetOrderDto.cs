using System;

namespace BeerDrive.DTOs
{
    public class GetOrderDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string User { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
