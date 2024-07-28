using System;

namespace BeerDrive.DTOs
{
    public class GetPositionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
