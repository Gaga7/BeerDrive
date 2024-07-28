using System;

namespace BeerDrive.DTOs
{
    public class GetProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
        public Guid SupplierId { get; set; }
        public string Supplier { get; set; }
        public decimal UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid MeasureUnitTypeId { get; set; }
        public string MeasureUnitType { get; set; }
        public bool DisableCheckInStock { get; set; }
        public bool SetPriceDuringSell { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
