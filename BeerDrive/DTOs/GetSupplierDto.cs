using System;

namespace BeerDrive.DTOs
{
    public class GetSupplierDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Mobile { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
