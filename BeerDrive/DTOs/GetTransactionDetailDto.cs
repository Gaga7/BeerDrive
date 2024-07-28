using System;

namespace BeerDrive.DTOs
{
    public class GetTransactionDetailDto
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Code { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
