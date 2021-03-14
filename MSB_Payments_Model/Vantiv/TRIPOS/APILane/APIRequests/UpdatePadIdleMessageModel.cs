using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APILane.APIRequests
{
    [Serializable]
    public class UpdatePadIdleMessageModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("idleMessage")]
            public string IdleMessage { get; set; }
        }


    }
}
