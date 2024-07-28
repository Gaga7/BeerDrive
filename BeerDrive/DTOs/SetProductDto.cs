using System;

namespace BeerDrive.DTOs
{
    public class SetProductDto
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? SupplierId { get; set; }
        public decimal? UnitInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public Guid? MeasureUnitTypeId { get; set; }
        public bool DisableCheckInStock { get; set; }
        public bool SetPriceDuringSell { get; set; }
    }
}
