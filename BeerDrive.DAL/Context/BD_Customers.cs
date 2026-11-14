using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Customers : AuditableEntity
    {
        public BD_Customers()
        {
            BD_CustomerScoreTransactions = new HashSet<BD_CustomerScoreTransactions>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(12)]
        public string Mobile { get; set; }

        public decimal Score { get; set; }

        public virtual ICollection<BD_CustomerScoreTransactions> BD_CustomerScoreTransactions { get; set; }
    }
}
