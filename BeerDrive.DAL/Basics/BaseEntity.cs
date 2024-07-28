using System;

namespace BeerDrive.DAL.Basics
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}
