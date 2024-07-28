using System;

namespace BeerDrive.DTOs
{
    public class SetSupplierDto
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? MobileIndexId { get; set; }
        public string Mobile { get; set; }
    }
}
