using System;

namespace BeerDrive.DTOs
{
    public class GetCustomerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public decimal Score { get; set; }
    }
}
