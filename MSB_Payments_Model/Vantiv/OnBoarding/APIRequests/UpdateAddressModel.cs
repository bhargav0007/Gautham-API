using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{

       [Serializable]
    public class UpdateAddressModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("addressLine1")]
            public string AddressLine1 { get; set; }
            [Required]
            [JsonPropertyName("addressLine2")]
            public string AddressLine2 { get; set; }
            [Required]
            [JsonPropertyName("city")]
            public string City { get; set; }
            [Required]
            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }
            [Required]
            [JsonPropertyName("postalCode")]
            public string PostalCode { get; set; }

            [JsonPropertyName("postalCodeExtension")]
            public string PostalCodeExtension { get; set; }
        }


    }
}
