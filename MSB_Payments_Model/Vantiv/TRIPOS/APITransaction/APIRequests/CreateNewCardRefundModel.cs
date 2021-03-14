using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class CreateNewCardRefundModel : BaseModel
    {
        public class Address
        {
            [JsonPropertyName("billingAddress1")]
            public string BillingAddress1 { get; set; }

            [JsonPropertyName("billingAddress2")]
            public string BillingAddress2 { get; set; }

            [JsonPropertyName("billingCity")]
            public string BillingCity { get; set; }

            [JsonPropertyName("billingEmail")]
            public string BillingEmail { get; set; }

            [JsonPropertyName("billingName")]
            public string BillingName { get; set; }

            [JsonPropertyName("billingPhone")]
            public string BillingPhone { get; set; }

            [JsonPropertyName("billingPostalCode")]
            public string BillingPostalCode { get; set; }

            [JsonPropertyName("billingState")]
            public string BillingState { get; set; }

            [JsonPropertyName("shippingAddress1")]
            public string ShippingAddress1 { get; set; }

            [JsonPropertyName("shippingAddress2")]
            public string ShippingAddress2 { get; set; }

            [JsonPropertyName("shippingCity")]
            public string ShippingCity { get; set; }

            [JsonPropertyName("shippingEmail")]
            public string ShippingEmail { get; set; }

            [JsonPropertyName("shippingName")]
            public string ShippingName { get; set; }

            [JsonPropertyName("shippingPhone")]
            public string ShippingPhone { get; set; }

            [JsonPropertyName("shippingPostalCode")]
            public string ShippingPostalCode { get; set; }

            [JsonPropertyName("shippingState")]
            public string ShippingState { get; set; }
        }

        public class Configuration
        {
            [JsonPropertyName("allowPartialApprovals")]
            public bool AllowPartialApprovals { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public bool CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("isGiftSupported")]
            public string IsGiftSupported { get; set; }

            [JsonPropertyName("isManualEntryAllowed")]
            public string IsManualEntryAllowed { get; set; }

            [JsonPropertyName("marketCode")]
            public string MarketCode { get; set; }

            [JsonPropertyName("promptForSignature")]
            public string PromptForSignature { get; set; }

            [JsonPropertyName("provisionalAmount")]
            public string ProvisionalAmount { get; set; }

            [JsonPropertyName("userInputTimeout")]
            public string UserInputTimeout { get; set; }
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
            [JsonPropertyName("address")]
            public Address Address { get; set; }

            [JsonPropertyName("cardHolderPresentCode")]
            public string CardHolderPresentCode { get; set; }

            [JsonPropertyName("clerkNumber")]
            public string ClerkNumber { get; set; }

            [JsonPropertyName("commercialCardCustomerCode")]
            public string CommercialCardCustomerCode { get; set; }

            [JsonPropertyName("configuration")]
            public Configuration Configuration { get; set; }

            [JsonPropertyName("convenienceFeeAmount")]
            public int ConvenienceFeeAmount { get; set; }

            [JsonPropertyName("displayTransactionAmount")]
            public bool DisplayTransactionAmount { get; set; }

            [JsonPropertyName("getToken")]
            public string GetToken { get; set; }

            [JsonPropertyName("invokeManualEntry")]
            public bool InvokeManualEntry { get; set; }

            [JsonPropertyName("isCscSupported")]
            public string IsCscSupported { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("preRead")]
            public bool PreRead { get; set; }

            [JsonPropertyName("quickChip")]
            public bool QuickChip { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("salesTaxAmount")]
            public int SalesTaxAmount { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("storeCard")]
            public StoreCard StoreCard { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }
            [Required]
            [JsonPropertyName("transactionAmount")]
            public string TransactionAmount { get; set; }
        }


    }
}
