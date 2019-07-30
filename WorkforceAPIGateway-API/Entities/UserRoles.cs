using System;
using System.Collections.Generic;
using System.Text;

namespace WorkforceAPIGateway_API.Entities
{
    public class UserRoles
    {
        public static UserRoles.Values FromString(string value)
        {
            return (UserRoles.Values)Enum.Parse(typeof(UserRoles.Values), value);
        }
        public enum Values
        {
            GENERALUSER=1,
            ADMIN=2
        }
    }
}
