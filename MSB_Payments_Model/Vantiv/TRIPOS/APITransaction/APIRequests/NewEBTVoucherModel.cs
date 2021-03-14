using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class NewEBTVoucherModel : BaseModel
    {
        public class Configuration
        {
            [JsonPropertyName("checkForDuplicateTransactions")]
            public bool CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("marketCode")]
            public string MarketCode { get; set; }
        }

        public class Root
        {
            [Required]
            [JsonPropertyName("approvalNumber")]
            public string ApprovalNumber { get; set; }

            [JsonPropertyName("cardHolderPresentCode")]
            public string CardHolderPresentCode { get; set; }

            [JsonPropertyName("clerkNumber")]
            public string ClerkNumber { get; set; }

            [JsonPropertyName("configuration")]
            public Configuration Configuration { get; set; }

            [JsonPropertyName("isCscSupported")]
            public string IsCscSupported { get; set; }

            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }

            [Required]
            [JsonPropertyName("transactionAmount")]
            public int TransactionAmount { get; set; }

            [Required]
            [JsonPropertyName("voucherNumber")]
            public string VoucherNumber { get; set; }
        }

    }
}
