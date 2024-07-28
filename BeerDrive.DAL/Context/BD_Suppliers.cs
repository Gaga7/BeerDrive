using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Suppliers : AuditableEntity
    {
        public BD_Suppliers()
        {
            BD_Products = new HashSet<BD_Products>();
        }

        [Required]
        public string Name { get; set; }

        public Guid ContactId { get; set; }
        
        public virtual BD_SupplierContacts BD_SupplierContacts { get; set; }
        public virtual ICollection<BD_Products> BD_Products { get; set; }
    }
}
