using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Products : AuditableEntity
    {
        public BD_Products()
        {
            BD_OrderDetails = new HashSet<BD_OrderDetails>();
            BD_TransactionDetails = new HashSet<BD_TransactionDetails>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Barcode { get; set; }

        public Guid CategoryId { get; set; }

        public Guid SupplierId { get; set; }

        public decimal UnitInStock { get; set; }

        public decimal UnitPrice { get; set; }

        public Guid MeasureUnitTypeId { get; set; }

        public bool DisableCheckInStock { get; set; }

        public bool SetPriceDuringSell { get; set; }

        public virtual BD_Categories BD_Categories { get; set; }
        public virtual BD_Suppliers BD_Suppliers { get; set; }
        public virtual BD_MeasureUnitTypes BD_MeasureUnitTypes { get; set; }
        public virtual ICollection<BD_OrderDetails> BD_OrderDetails { get; set; }
        public virtual ICollection<BD_TransactionDetails> BD_TransactionDetails { get; set; }
    }
}
