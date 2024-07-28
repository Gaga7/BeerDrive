using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Categories : AuditableEntity
    {
        public BD_Categories()
        {
            BD_Products = new HashSet<BD_Products>();
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public virtual ICollection<BD_Products> BD_Products { get; set; }
    }
}
