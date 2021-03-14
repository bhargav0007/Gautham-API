using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class CreateNewFullReversalModel : BaseModel
    {
        public class Configuration
        {
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

            [JsonPropertyName("convenienceFeeAmount")]
            public int ConvenienceFeeAmount { get; set; }

            [JsonPropertyName("ebtType")]
            public string EbtType { get; set; }

            [JsonPropertyName("getToken")]
            public string GetToken { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("networkTransactionID")]
            public string NetworkTransactionID { get; set; }

            [JsonPropertyName("recurringPaymentType")]
            public string RecurringPaymentType { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("storeCard")]
            public StoreCard StoreCard { get; set; }

            [JsonPropertyName("submissionType")]
            public string SubmissionType { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }
            [Required]
            [JsonPropertyName("transactionAmount")]
            public int TransactionAmount { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

    }
}
