using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class UpdateOwnerModel : BaseModel
    {
        public class IssuedId
        {
            
            [JsonPropertyName("idType")]
            public string IdType { get; set; }

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

        public class Root
        {
            [Required]
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }
            [Required]
            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("middleInitial")]
            public string MiddleInitial { get; set; }
            [Required]
            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("phoneNumberExt")]
            public string PhoneNumberExt { get; set; }

            [JsonPropertyName("faxNumber")]
            public string FaxNumber { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("ownershipPercentage")]
            public string OwnershipPercentage { get; set; }

            [JsonPropertyName("ssn")]
            public string Ssn { get; set; }

            [JsonPropertyName("dob")]
            public string Dob { get; set; }
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

            [JsonPropertyName("issuedIds")]
            public List<IssuedId> IssuedIds { get; set; }
        }


    }
}
