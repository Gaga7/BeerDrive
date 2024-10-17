using System;
using System.Collections.Generic;

namespace BeerDrive.DTOs
{
    public class GetUserDto
    {
        public Guid Id { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public Guid PositionId { get; set; }
        public string Position { get; set; }
        public bool Status { get; set; }
        public List<Guid> RoleIds { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOperator { get; set; }
        public bool IsManager { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
