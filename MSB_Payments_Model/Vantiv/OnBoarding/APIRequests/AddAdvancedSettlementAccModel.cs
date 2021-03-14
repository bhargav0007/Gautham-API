using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class AddAdvancedSettlementAccModel : BaseModel
    {
        public class BankAccount
        {
            [JsonPropertyName("ddaType")]
            public string DdaType { get; set; }

            [JsonPropertyName("achType")]
            public string AchType { get; set; }

            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("routingNumber")]
            public string RoutingNumber { get; set; }
        }

        public class Root
        {
            [Required]
            [JsonPropertyName("bankAccount")]
            public BankAccount BankAccount { get; set; }
            [Required]
            [JsonPropertyName("settlementCategories")]
            public List<string> SettlementCategories { get; set; }

            [JsonPropertyName("oneACHForAllCategories")]
            public string OneACHForAllCategories { get; set; }

            [JsonPropertyName("oneACHForCreditAndDebit")]
            public string OneACHForCreditAndDebit { get; set; }
        }


    }
}
