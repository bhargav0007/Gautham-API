using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class UpdateDefaultBankAccountModel : BaseModel
    {
       
        public class Root
        {
            [Required]
            [JsonPropertyName("ddaType")]
            public string DdaType { get; set; }

            [JsonPropertyName("achType")]
            public string AchType { get; set; }
            [Required]
            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }
            [Required]
            [JsonPropertyName("routingNumber")]
            public string RoutingNumber { get; set; }
        }



    }
}
