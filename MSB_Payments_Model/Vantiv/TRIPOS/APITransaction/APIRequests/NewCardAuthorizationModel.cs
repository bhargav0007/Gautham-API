using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
  public class NewCardAuthorizationModel : BaseModel
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

        public class AutoRental
        {
            [JsonPropertyName("duration")]
            public int Duration { get; set; }
        }

        public class Configuration
        {
            [JsonPropertyName("allowPartialApprovals")]
            public bool AllowPartialApprovals { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public bool CheckForDuplicateTransactions { get; set; }

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

        public class Healthcare
        {
            [JsonPropertyName("clinic")]
            public int Clinic { get; set; }

            [JsonPropertyName("dental")]
            public int Dental { get; set; }

            [JsonPropertyName("prescription")]
            public int Prescription { get; set; }

            [JsonPropertyName("total")]
            public int Total { get; set; }

            [JsonPropertyName("vision")]
            public int Vision { get; set; }
        }

        public class Lodging
        {
            [JsonPropertyName("duration")]
            public int Duration { get; set; }

            [JsonPropertyName("prestigiousPropertyCode")]
            public string PrestigiousPropertyCode { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("address")]
            public Address Address { get; set; }

            [JsonPropertyName("autoRental")]
            public AutoRental AutoRental { get; set; }

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

            [JsonPropertyName("healthcare")]
            public Healthcare Healthcare { get; set; }

            [JsonPropertyName("invokeManualEntry")]
            public bool InvokeManualEntry { get; set; }

            [JsonPropertyName("isCscSupported")]
            public string IsCscSupported { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("lodging")]
            public Lodging Lodging { get; set; }

            [JsonPropertyName("networkTransactionID")]
            public string NetworkTransactionID { get; set; }

            [JsonPropertyName("nonFinancialExpected")]
            public bool NonFinancialExpected { get; set; }

            [JsonPropertyName("preRead")]
            public bool PreRead { get; set; }

            [JsonPropertyName("quickChip")]
            public bool QuickChip { get; set; }

            [JsonPropertyName("recurringPaymentType")]
            public string RecurringPaymentType { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("salesTaxAmount")]
            public int SalesTaxAmount { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("submissionType")]
            public string SubmissionType { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }

            [JsonPropertyName("tipAmount")]
            public int TipAmount { get; set; }
            [Required]
            [JsonPropertyName("transactionAmount")]
            public string TransactionAmount { get; set; }
        }


    }
}

