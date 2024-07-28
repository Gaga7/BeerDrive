using System;

namespace BeerDrive.DAL.Basics
{
    public abstract class AuditableEntity : BaseEntity
    {
        public virtual DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public virtual Guid CreatedBy { get; set; }

        public virtual DateTime? DateChanged { get; set; }
        public virtual Guid? ChangedBy { get; set; }

        public virtual DateTime? DateDeleted { get; set; }
        public virtual Guid? DeletedBy { get; set; }
    }
}
