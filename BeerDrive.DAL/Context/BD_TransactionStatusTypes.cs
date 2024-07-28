using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_TransactionStatusTypes : AuditableEntity
    {
        public BD_TransactionStatusTypes()
        {
            BD_Transactions = new HashSet<BD_Transactions>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BD_Transactions> BD_Transactions { get; set; }
    }
}
