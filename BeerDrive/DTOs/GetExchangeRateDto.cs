using System;

namespace BeerDrive.DTOs
{
    public class GetExchangeRateDto
    {
        public Guid Id { get; set; }
        public Guid ExchangeTypeId { get; set; }
        public string ExchangeType { get; set; }
        public decimal Score { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
