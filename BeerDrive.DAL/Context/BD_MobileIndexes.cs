using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_MobileIndexes : AuditableEntity
    {
        public BD_MobileIndexes()
        {
            BD_SupplierContacts = new HashSet<BD_SupplierContacts>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BD_SupplierContacts> BD_SupplierContacts { get; set; }
    }
}
