using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APILane.APIRequests
{
    [Serializable]
    public class CreateLaneModel : BaseModel
    {     
            public class Root
            {
                [Required]
                [JsonPropertyName("laneId")]
                public int LaneId { get; set; }

                [JsonPropertyName("description")]
                public string Description { get; set; }
                [Required]
                [JsonPropertyName("terminalId")]
                public string TerminalId { get; set; }
                [Required]
                [JsonPropertyName("activationCode")]
                public string ActivationCode { get; set; }

                [JsonPropertyName("contactlessMsdEnabled")]
                public string ContactlessMsdEnabled { get; set; }

                [JsonPropertyName("contactlessEmvEnabled")]
                public string ContactlessEmvEnabled { get; set; }

                [JsonPropertyName("quickChipEnabled")]
                public string QuickChipEnabled { get; set; }

                [JsonPropertyName("quickChipDataLifetime")]
                public int QuickChipDataLifetime { get; set; }
            }

    }
}
