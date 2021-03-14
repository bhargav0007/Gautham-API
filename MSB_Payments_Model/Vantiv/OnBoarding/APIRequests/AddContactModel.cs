using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class AddContactModel : BaseModel
    {
        public class Root
        {
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
            [Required]
            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("phoneNumberExt")]
            public string PhoneNumberExt { get; set; }
            [Required]
            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("faxNumber")]
            public string FaxNumber { get; set; }
            [Required]
            [JsonPropertyName("type")]
            public string Type { get; set; }
        }



    }
}
