using System;

namespace MSB.Payments.Model
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedByUserID { get; set; }
    }
}
