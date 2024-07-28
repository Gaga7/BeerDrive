using System;

namespace BeerDrive.DTOs
{
    public class GetMobileIndexDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
