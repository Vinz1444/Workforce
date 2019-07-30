using System;
using System.Collections.Generic;
using System.Text;

namespace WorkforceAPIGateway_API.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public UserRoles.Values Role { get; set; }
        public int  companyId { get; set; }
        
    }

}
