using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class CreatePCIAssistAccountModel : BaseModel
    {
        public class PhysicalAddress
        {
            [JsonPropertyName("addressLine1")]
            public string AddressLine1 { get; set; }

            [JsonPropertyName("addressLine2")]
            public string AddressLine2 { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("postalCode")]
            public string PostalCode { get; set; }

            [JsonPropertyName("postalCodeExtension")]
            public string PostalCodeExtension { get; set; }
        }

        public class PrimaryContact
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("middleInitial")]
            public string MiddleInitial { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("phoneNumberExt")]
            public string PhoneNumberExt { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("faxNumber")]
            public string FaxNumber { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("legalName")]
            public string LegalName { get; set; }

            [JsonPropertyName("partnerGuid")]
            public string PartnerGuid { get; set; }

            [JsonPropertyName("physicalAddress")]
            public PhysicalAddress PhysicalAddress { get; set; }

            [JsonPropertyName("primaryContact")]
            public PrimaryContact PrimaryContact { get; set; }
        }

    }
}
