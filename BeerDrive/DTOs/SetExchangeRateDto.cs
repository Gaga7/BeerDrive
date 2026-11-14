using System;

namespace BeerDrive.DTOs
{
    public class SetExchangeRateDto
    {
        public Guid? ExchangeTypeId { get; set; }
        public decimal? Score { get; set; }
        public decimal? Amount { get; set; }
    }
}
