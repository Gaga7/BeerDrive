using BeerDrive.DAL.Basics;
using System;

namespace BeerDrive.DAL.Context
{
    public partial class BD_UserRoles : AuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual BD_Users BD_Users { get; set; }
        public virtual BD_Roles BD_Roles { get; set; }
    }
}
