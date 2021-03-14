using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIHeader
{
    [Serializable]
    public class OnboardingHeaderModel : BaseModel
    {
        [Required]
        [JsonPropertyName("v_CorrelationId")]
        public string V_CorrelationId { get; set; }

        [JsonPropertyName("Content-Type")]
        public string Content_Type { get; set; }
    }
}
