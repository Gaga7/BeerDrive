using BeerDrive.DAL.Basics;
using System;

namespace BeerDrive.DAL.Context
{
    public partial class BD_TransactionDetails : AuditableEntity
    {
        public Guid TransactionId { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public string Code { get; set; }

        public virtual BD_Transactions BD_Transactions { get; set; }

        public virtual BD_Products BD_Products { get; set; }
    }
}
