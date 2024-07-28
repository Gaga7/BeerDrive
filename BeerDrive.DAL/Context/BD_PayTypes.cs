using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_PayTypes : AuditableEntity
    {
        public BD_PayTypes()
        {
            BD_Transactions = new HashSet<BD_Transactions>();
        }

        [Required]
        public string Name { get; set; }

        public int OrderIndex { get; set; }

        public virtual ICollection<BD_Transactions> BD_Transactions { get; set; }
    }
}
