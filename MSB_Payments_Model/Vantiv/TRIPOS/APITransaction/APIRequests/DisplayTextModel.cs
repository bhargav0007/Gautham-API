using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class DisplayTextModel : BaseModel
    {
        public class Root
        {
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("multiLineText")]
            public List<string> MultiLineText { get; set; }

            [JsonPropertyName("text")]
            public string Text { get; set; }
        }



    }
}
