using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnablePassTokenModel : BaseModel
    {
        public class Root
        {
            [JsonPropertyName("enablePassToken")]
            public bool EnablePassToken { get; set; }
        }


    }
}
