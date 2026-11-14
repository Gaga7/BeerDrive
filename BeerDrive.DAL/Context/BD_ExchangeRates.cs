using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;

namespace BeerDrive.DAL.Context
{
    public partial class BD_ExchangeRates : AuditableEntity
    {
        public BD_ExchangeRates()
        {
            BD_CustomerScoreTransactions = new HashSet<BD_CustomerScoreTransactions>();
        }

        public Guid ExchangeTypeId { get; set; }
        public decimal Score { get; set; }
        public decimal Amount { get; set; }

        public virtual BD_ExchangeTypes BD_ExchangeTypes { get; set; }
        public virtual ICollection<BD_CustomerScoreTransactions> BD_CustomerScoreTransactions { get; set; }
    }
}
