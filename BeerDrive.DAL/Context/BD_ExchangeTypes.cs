using BeerDrive.DAL.Basics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_ExchangeTypes : AuditableEntity
    {
        public BD_ExchangeTypes()
        {
            BD_ExchangeRates = new HashSet<BD_ExchangeRates>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BD_ExchangeRates> BD_ExchangeRates { get; set; }
    }
}
