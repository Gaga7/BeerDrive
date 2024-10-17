using System;

namespace BeerDrive.DTOs
{
    public class GetTransactionDto
    {
        public Guid Id { get; set; }
        public Guid? PayTypeId { get; set; }
        public string PayTypeName { get; set; }
        public Guid TransactionStatusTypeId { get; set; }
        public string TransactionStatusTypeName { get; set; }
        public string TransactionNumber { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Change { get; set; }
        public string Code { get; set; }
        public DateTime DateCreated { get; set; }
        public string User { get; set; }
    }
}
