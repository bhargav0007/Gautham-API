using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{  
    [Serializable]
    public class UpdateTerminalModel : BaseModel
    {
      
        public class Customization
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("value")]
            public string Value { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("customizations")]
            public List<Customization> Customizations { get; set; }
        }



    }
}
