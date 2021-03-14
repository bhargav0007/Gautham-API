using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class CreateTerminalsModel : BaseModel
    {
        public class Root
        {
            [JsonPropertyName("tid")]
            public string Tid { get; set; }

            [JsonPropertyName("quantity")]
            public string Quantity { get; set; }
        }
    }
}
