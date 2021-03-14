using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APILane.APIRequests
{
    [Serializable]
    public class UpdateLaneModel : BaseModel
    {
        public class Root
        {
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
