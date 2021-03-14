using System;
using System.Collections.Generic;

namespace MSB.Payments.Model.UserManagement
{
    public class Role : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
