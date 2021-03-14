using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class PrintReceiptToPinPadModel : BaseModel
    {
        public class Tag
        {
            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("value")]
            public string Value { get; set; }
        }

        public class Emv
        {
            [JsonPropertyName("tags")]
            public List<Tag> Tags { get; set; }

            [JsonPropertyName("applicationIdentifier")]
            public string ApplicationIdentifier { get; set; }

            [JsonPropertyName("applicationLabel")]
            public string ApplicationLabel { get; set; }

            [JsonPropertyName("applicationPreferredName")]
            public string ApplicationPreferredName { get; set; }

            [JsonPropertyName("cryptogram")]
            public string Cryptogram { get; set; }

            [JsonPropertyName("issuerCodeTableIndex")]
            public string IssuerCodeTableIndex { get; set; }
        }

        public class Root
        {
            [Required]
            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("approvalNumber")]
            public string ApprovalNumber { get; set; }
            [Required]
            [JsonPropertyName("cardLogo")]
            public string CardLogo { get; set; }

            [JsonPropertyName("cashbackAmount")]
            public int CashbackAmount { get; set; }

            [JsonPropertyName("copyType")]
            public string CopyType { get; set; }

            [JsonPropertyName("currencyCode")]
            public string CurrencyCode { get; set; }

            [JsonPropertyName("customTemplate")]
            public string CustomTemplate { get; set; }

            [JsonPropertyName("emv")]
            public Emv Emv { get; set; }
            [Required]
            [JsonPropertyName("entryMode")]
            public string EntryMode { get; set; }

            [JsonPropertyName("footer")]
            public List<string> Footer { get; set; }

            [JsonPropertyName("header")]
            public List<string> Header { get; set; }

            [JsonPropertyName("hostResponseCode")]
            public string HostResponseCode { get; set; }
            [Required]
            [JsonPropertyName("isApproved")]
            public bool IsApproved { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }
            [Required]
            [JsonPropertyName("merchantId")]
            public string MerchantId { get; set; }

            [JsonPropertyName("pinVerified")]
            public bool PinVerified { get; set; }

            [JsonPropertyName("receiptType")]
            public string ReceiptType { get; set; }
            [Required]
            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }
            [Required]
            [JsonPropertyName("subTotalAmount")]
            public int SubTotalAmount { get; set; }
            [Required]
            [JsonPropertyName("terminalId")]
            public string TerminalId { get; set; }

            [JsonPropertyName("tipAmount")]
            public int TipAmount { get; set; }

            [JsonPropertyName("totalAmount")]
            public int TotalAmount { get; set; }

            [JsonPropertyName("transactionDateTime")]
            public string TransactionDateTime { get; set; }

            [Required]
            [JsonPropertyName("transactionId")]
            public string TransactionId { get; set; }
        }


    }
}
