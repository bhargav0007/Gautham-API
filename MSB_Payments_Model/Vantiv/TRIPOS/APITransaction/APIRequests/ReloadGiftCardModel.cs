using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class ReloadGiftCardModel
    {
        public class Configuration
        {
            [JsonPropertyName("allowPartialApprovals")]
            public bool AllowPartialApprovals { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public bool CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("marketCode")]
            public string MarketCode { get; set; }
        }

        public class StoreCard
        {
            [JsonPropertyName("Id")]
            public string Id { get; set; }

            [JsonPropertyName("Password")]
            public string Password { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("cardHolderPresentCode")]
            public string CardHolderPresentCode { get; set; }

            [JsonPropertyName("clerkNumber")]
            public string ClerkNumber { get; set; }

            [JsonPropertyName("configuration")]
            public Configuration Configuration { get; set; }

            [JsonPropertyName("invokeManualEntry")]
            public bool InvokeManualEntry { get; set; }

            [JsonPropertyName("isCscSupported")]
            public string IsCscSupported { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("storeCard")]
            public StoreCard StoreCard { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }
            [Required]
            [JsonPropertyName("transactionAmount")]
            public int TransactionAmount { get; set; }
        }
    }
}
