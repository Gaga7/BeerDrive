﻿using System;

namespace BeerDrive.DTOs
{
    public class SetTransactionDetailDto
    {
        public Guid? TransactionId { get; set; }
        public Guid? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
