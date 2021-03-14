using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class CreateCardAccTokenModel : BaseModel
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

        public class Root
        {
            [JsonPropertyName("address")]
            public Address Address { get; set; }

            [JsonPropertyName("expirationMonth")]
            public string ExpirationMonth { get; set; }

            [JsonPropertyName("expirationYear")]
            public string ExpirationYear { get; set; }

            [JsonPropertyName("invokeManualEntry")]
            public bool InvokeManualEntry { get; set; }

            [JsonPropertyName("isCscSupported")]
            public string IsCscSupported { get; set; }
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }
            [Required]
            [JsonPropertyName("paymentAccountReferenceNumber")]
            public string PaymentAccountReferenceNumber { get; set; }
        }
    }
}
