using System;

namespace BeerDrive.DTOs
{
    public class SetPayDto
    {
        public Guid? Id { get; set; }
        public Guid? PayTypeId { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Change { get; set; }
    }
}
