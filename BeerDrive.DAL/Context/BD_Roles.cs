using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Roles : AuditableEntity
    {
        public BD_Roles()
        {
            BD_UserRoles = new HashSet<BD_UserRoles>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BD_UserRoles> BD_UserRoles { get; set; }
    }
}
