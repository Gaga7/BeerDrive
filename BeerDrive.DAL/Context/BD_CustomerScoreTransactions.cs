using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;

namespace BeerDrive.DAL.Context
{
    public partial class BD_CustomerScoreTransactions : AuditableEntity
    {
        public BD_CustomerScoreTransactions()
        {
            BD_Transactions = new HashSet<BD_Transactions>();
        }

        public Guid CustomerId { get; set; }
        public Guid ExchangeRateId { get; set; }
        public decimal Score { get; set; }

        public virtual BD_Customers BD_Customers { get; set; }
        public virtual BD_ExchangeRates BD_ExchangeRates { get; set; }
        public virtual ICollection<BD_Transactions> BD_Transactions { get; set; }
    }
}
