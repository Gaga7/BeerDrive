using System;

namespace BeerDrive.DTOs
{
    public class GetSupplierWithContractDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? MobileIndexId { get; set; }
        public string Mobile { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
