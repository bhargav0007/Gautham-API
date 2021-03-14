using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class CreateTokenCardSaleModel : BaseModel
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

        public class AdjustmentData
        {
            [JsonPropertyName("amount")]
            public int Amount { get; set; }

            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("extraChargesDetail")]
            public List<string> ExtraChargesDetail { get; set; }
        }

        public class PickupData
        {
            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("countryCode")]
            public string CountryCode { get; set; }

            [JsonPropertyName("date")]
            public string Date { get; set; }

            [JsonPropertyName("location")]
            public string Location { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }
        }

        public class ReturnData
        {
            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("countryCode")]
            public string CountryCode { get; set; }

            [JsonPropertyName("date")]
            public string Date { get; set; }

            [JsonPropertyName("distance")]
            public int Distance { get; set; }

            [JsonPropertyName("distanceUnit")]
            public string DistanceUnit { get; set; }

            [JsonPropertyName("locationId")]
            public string LocationId { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }
        }

        public class AutoRental
        {
            [JsonPropertyName("adjustmentData")]
            public AdjustmentData AdjustmentData { get; set; }

            [JsonPropertyName("agreementNumber")]
            public string AgreementNumber { get; set; }

            [JsonPropertyName("customerName")]
            public string CustomerName { get; set; }

            [JsonPropertyName("dailyRentalRate")]
            public int DailyRentalRate { get; set; }

            [JsonPropertyName("duration")]
            public int Duration { get; set; }

            [JsonPropertyName("insuranceCharges")]
            public int InsuranceCharges { get; set; }

            [JsonPropertyName("noShowIndicator")]
            public string NoShowIndicator { get; set; }

            [JsonPropertyName("pickupData")]
            public PickupData PickupData { get; set; }

            [JsonPropertyName("returnData")]
            public ReturnData ReturnData { get; set; }

            [JsonPropertyName("vehicleClassCode")]
            public string VehicleClassCode { get; set; }

            [JsonPropertyName("weeklyRentalRate")]
            public int WeeklyRentalRate { get; set; }
        }

        public class Configuration
        {
            [JsonPropertyName("allowPartialApprovals")]
            public bool AllowPartialApprovals { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public bool CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("marketCode")]
            public string MarketCode { get; set; }
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

        public class Root
        {
            [JsonPropertyName("address")]
            public Address Address { get; set; }
            
            [JsonPropertyName("autoRental")]
            public AutoRental AutoRental { get; set; }
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

            [JsonPropertyName("healthcare")]
            public Healthcare Healthcare { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }

            [JsonPropertyName("referenceNumber")]
            public string ReferenceNumber { get; set; }

            [JsonPropertyName("shiftId")]
            public string ShiftId { get; set; }

            [JsonPropertyName("ticketNumber")]
            public string TicketNumber { get; set; }

            [JsonPropertyName("tipAmount")]
            public int TipAmount { get; set; }
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
