using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class UpdateSubmerchantModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("dbaName")]
            public string DbaName { get; set; }
            [Required]
            [JsonPropertyName("billingDescriptor")]
            public string BillingDescriptor { get; set; }
            [Required]
            [JsonPropertyName("businessType")]
            public string BusinessType { get; set; }
            [Required]
            [JsonPropertyName("mccCode")]
            public string MccCode { get; set; }
            [Required]
            [JsonPropertyName("businessEstablishedDate")]
            public string BusinessEstablishedDate { get; set; }
            [Required]
            [JsonPropertyName("websiteUrl")]
            public string WebsiteUrl { get; set; }
        }
    }
}
