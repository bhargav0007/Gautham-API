using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APILane.APIRequests
{
    [Serializable]
    public class ComandReconfigurePadModel :BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("rebootTime")]
            public string RebootTime { get; set; }
            [Required]
            [JsonPropertyName("isDisplayCustomAidScreen")]
            public bool IsDisplayCustomAidScreen { get; set; }
        }

    }
}
