using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class DisplayScrollingItemsOnPinpadModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }
            [Required]
            [JsonPropertyName("lineItem")]
            public string LineItem { get; set; }
            [Required]
            [JsonPropertyName("subtotal")]
            public string Subtotal { get; set; }
            [Required]
            [JsonPropertyName("tax")]
            public string Tax { get; set; }
            [Required]
            [JsonPropertyName("total")]
            public string Total { get; set; }
        }


    }
}
