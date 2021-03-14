using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnableCheckModel
    {
        public class PerCustomer
        {
            [JsonPropertyName("dailyTransactionCount")]
            public int DailyTransactionCount { get; set; }

            [JsonPropertyName("dailyTransactionAmount")]
            public int DailyTransactionAmount { get; set; }

            [JsonPropertyName("dailyTransactionDeclineCount")]
            public int DailyTransactionDeclineCount { get; set; }
        }

        public class TransactionThresholds
        {
            [JsonPropertyName("singleTransactionAmount")]
            public int SingleTransactionAmount { get; set; }

            [JsonPropertyName("dailyTransactionCount")]
            public int DailyTransactionCount { get; set; }

            [JsonPropertyName("dailyTransactionAmount")]
            public int DailyTransactionAmount { get; set; }

            [JsonPropertyName("monthlyTransactionCount")]
            public int MonthlyTransactionCount { get; set; }

            [JsonPropertyName("monthlyTransactionAmount")]
            public int MonthlyTransactionAmount { get; set; }

            [JsonPropertyName("perCustomer")]
            public PerCustomer PerCustomer { get; set; }
        }

        public class Root
        {
            [Required]
            [JsonPropertyName("enableEcheck")]
            public bool EnableEcheck { get; set; }

            [Required]
            [JsonPropertyName("transactionThresholds")]
            public TransactionThresholds TransactionThresholds { get; set; }
        }
        
    }
}
