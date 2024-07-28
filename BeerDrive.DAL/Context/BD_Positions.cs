using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Positions : AuditableEntity
    {
        public BD_Positions()
        {
            BD_Users = new HashSet<BD_Users>();
        }

        public string Name { get; set; }

        public virtual ICollection<BD_Users> BD_Users { get; set; }
    }
}
