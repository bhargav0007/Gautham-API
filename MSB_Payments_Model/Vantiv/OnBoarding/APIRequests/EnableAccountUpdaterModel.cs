using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnableAccountUpdaterModel : BaseModel
    {
        public class Root
        {
            [JsonPropertyName("enableForPassToken")]
            public bool EnableForPassToken { get; set; }
        }

    }
}
