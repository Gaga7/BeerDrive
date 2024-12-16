using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Transactions : AuditableEntity
    {
        public BD_Transactions()
        {
            BD_TransactionDetails = new HashSet<BD_TransactionDetails>();
        }

        public Guid? PayTypeId { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid TransactionStatusTypeId { get; set; }

        public string TransactionNumber { get; set; }

        public decimal? TotalQuantity { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? Cash { get; set; }

        public decimal? Change { get; set; }

        public string Code { get; set; }

        public virtual BD_Users BD_Users { get; set; }
        public virtual BD_PayTypes BD_PayTypes { get; set; }
        public virtual BD_TransactionStatusTypes BD_TransactionStatusTypes { get; set; }
        public virtual ICollection<BD_TransactionDetails> BD_TransactionDetails { get; set; }
    }
}
