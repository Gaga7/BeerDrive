using BeerDrive.DAL.Basics;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerDrive.DAL.Context
{
    public partial class BD_OrderDetails : AuditableEntity
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public decimal Discount { get; set; }

        public virtual BD_Orders BD_Orders { get; set; }

        public virtual BD_Products BD_Products { get; set; }
    }
}
