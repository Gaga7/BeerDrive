using System;
using System.Collections.Generic;

namespace BeerDrive.DTOs
{
    public class SetUserDto
    {
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public Guid? PositionId { get; set; }
        public bool Status { get; set; }
        public List<Guid> RoleIds { get; set; }
    }
}
