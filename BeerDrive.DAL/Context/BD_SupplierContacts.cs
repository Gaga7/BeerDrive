using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_SupplierContacts : AuditableEntity
    {
        public BD_SupplierContacts()
        {
            BD_Suppliers = new HashSet<BD_Suppliers>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Guid MobileIndexId { get; set; }

        [Required]
        [StringLength(12)]
        public string Mobile { get; set; }

        public virtual BD_MobileIndexes BD_MobileIndexes { get; set; }

        public virtual ICollection<BD_Suppliers> BD_Suppliers { get; set; }
    }
}
