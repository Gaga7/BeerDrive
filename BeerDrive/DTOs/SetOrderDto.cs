using System;
using System.Collections.Generic;

namespace BeerDrive.DTOs
{
    public class SetOrderDto
    {
        public Guid? UserId { get; set; }
        public DateTime? OrderDate { get; set; }

        public List<SetOrderDetailDto> OrderDetails { get; set; }
    }
}
