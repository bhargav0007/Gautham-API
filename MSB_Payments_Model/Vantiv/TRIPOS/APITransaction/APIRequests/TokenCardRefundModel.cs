using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class TokenCardRefundModel : BaseModel
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

        public class Root
        {
            [Required]
            [JsonPropertyName("cardLogo")]
            public string CardLogo { get; set; }

            [JsonPropertyName("clerkNumber")]
            public string ClerkNumber { get; set; }

            [JsonPropertyName("configuration")]
            public Configuration Configuration { get; set; }

            [JsonPropertyName("convenienceFeeAmount")]
            public int ConvenienceFeeAmount { get; set; }

            [JsonPropertyName("expirationMonth")]
            public string ExpirationMonth { get; set; }

            [JsonPropertyName("expirationYear")]
            public string ExpirationYear { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }
            [Required]
            [JsonPropertyName("tokenId")]
            public string TokenId { get; set; }
            [Required]
            [JsonPropertyName("tokenProvider")]
            public string TokenProvider { get; set; }
            [Required]
            [JsonPropertyName("transactionAmount")]
            public int TransactionAmount { get; set; }
            [Required]
            [JsonPropertyName("vaultId")]
            public string VaultId { get; set; }
        }




    }
}
