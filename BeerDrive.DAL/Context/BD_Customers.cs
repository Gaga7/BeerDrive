using BeerDrive.DAL.Basics;
using System.ComponentModel.DataAnnotations;

namespace BeerDrive.DAL.Context
{
    public partial class BD_Customers : AuditableEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(12)]
        public string Mobile { get; set; }

        public decimal Score { get; set; }
    }
}
