using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class AddAddressModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("type")]
            public string Type { get; set; }
            [Required]
            [JsonPropertyName("addressLine1")]
            public string AddressLine1 { get; set; }

            [JsonPropertyName("addressLine2")]
            public string AddressLine2 { get; set; }
            [Required]
            [JsonPropertyName("city")]
            public string City { get; set; }
            [Required]
            [JsonPropertyName("state")]
            public string State { get; set; }
            [Required]
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
