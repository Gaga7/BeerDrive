using System;

namespace BeerDrive.DTOs
{
    public class GetPayTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
