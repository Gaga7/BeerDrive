using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Orders : AuditableEntity
    {
        public BD_Orders()
        {
            BD_OrderDetails = new HashSet<BD_OrderDetails>();
        }

        public Guid UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public decimal? TotalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public virtual BD_Users BD_Users { get; set; }

        public virtual ICollection<BD_OrderDetails> BD_OrderDetails { get; set; }
    }
}
