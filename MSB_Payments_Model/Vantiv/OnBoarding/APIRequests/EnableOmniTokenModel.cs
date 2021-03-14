using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnableOmniTokenModel :BaseModel
    {
        public class Root
        {
            [JsonPropertyName("enableOmniToken")]
            public bool EnableOmniToken { get; set; }
        }
    }
}
