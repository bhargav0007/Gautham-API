using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class AddExpressSubAccountModel :BaseModel
    {
        public class Root
        {
            [JsonPropertyName("batchCloseMethod")]
            public string BatchCloseMethod { get; set; }

            [JsonPropertyName("batchCloseTime")]
            public string BatchCloseTime { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public string CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("enableCommercialCardBINQuery")]
            public string EnableCommercialCardBINQuery { get; set; }
        }

    }
}
