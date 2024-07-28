using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_MeasureUnitTypes : AuditableEntity
    {
        public BD_MeasureUnitTypes()
        {
            BD_Products = new HashSet<BD_Products>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BD_Products> BD_Products { get; set; }
    }
}
