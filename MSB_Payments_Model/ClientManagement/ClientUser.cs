using System;
using System.Collections.Generic;

namespace MSB.Payments.Model.ClientManagement
{
    public class ClientUser : BaseModel
    {
        public int ClientId { get; set; }

        public int UserId { get; set; }
    }
}
