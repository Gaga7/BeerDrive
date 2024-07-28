using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Users : AuditableEntity
    {
        public BD_Users()
        {
            BD_Orders = new HashSet<BD_Orders>();
            BD_UserRoles = new HashSet<BD_UserRoles>();
            BD_Transactions = new HashSet<BD_Transactions>();
        }

        [Required]
        public string PersonalId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public Guid PositionId { get; set; }

        public bool Status { get; set; }

        public virtual BD_Positions BD_Positions { get; set; }
        public virtual ICollection<BD_Orders> BD_Orders { get; set; }
        public virtual ICollection<BD_UserRoles> BD_UserRoles { get; set; }
        public virtual ICollection<BD_Transactions> BD_Transactions { get; set; }
    }
}
