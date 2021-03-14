using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class UpdateIssueIdModel : BaseModel
    {
      
        public class Root
        {
            [Required]
            [JsonPropertyName("idNumber")]
            public string IdNumber { get; set; }

            [JsonPropertyName("issuedCity")]
            public string IssuedCity { get; set; }

            [JsonPropertyName("issuedState")]
            public string IssuedState { get; set; }

            [JsonPropertyName("issuedCountry")]
            public string IssuedCountry { get; set; }

            [JsonPropertyName("dateIssued")]
            public string DateIssued { get; set; }

            [JsonPropertyName("dateExpires")]
            public string DateExpires { get; set; }
        }


    }
}
