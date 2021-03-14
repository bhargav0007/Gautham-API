using MSB.Payments.Model.UserManagement;
using System;
using System.Collections.Generic;

namespace MSB.Payments.Model.UserManagement
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Role> Roles { get; set; }
    }
}
