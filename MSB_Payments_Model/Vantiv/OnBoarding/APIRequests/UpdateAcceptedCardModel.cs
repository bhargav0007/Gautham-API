using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class UpdateAcceptedCardModel : BaseModel
    {
        public class Attribute
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("value")]
            public string Value { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("attributes")]
            public List<Attribute> Attributes { get; set; }
        }


    }
}
