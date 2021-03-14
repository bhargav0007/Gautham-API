using MSB.Payments.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSMSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class IncreaseFinalTotModel : BaseModel
    {      
            public class AutoRental
            {
                [JsonPropertyName("duration")]
                public int Duration { get; set; }
            }

            public class Configuration
            {
                [JsonPropertyName("marketCode")]
                public string MarketCode { get; set; }
            }

            public class Lodging
            {
                [JsonPropertyName("duration")]
                public int Duration { get; set; }
            }

            public class Root
            {
                [JsonPropertyName("autoRental")]
                public AutoRental AutoRental { get; set; }

                [JsonPropertyName("cardHolderPresentCode")]
                public string CardHolderPresentCode { get; set; }

                [JsonPropertyName("clerkNumber")]
                public string ClerkNumber { get; set; }

                [JsonPropertyName("configuration")]
                public Configuration Configuration { get; set; }

                [JsonPropertyName("getToken")]
                public string GetToken { get; set; }

                [Required]
                [JsonPropertyName("laneId")]
                public int LaneId { get; set; }

                [JsonPropertyName("lodging")]
                public Lodging Lodging { get; set; }

                [JsonPropertyName("referenceNumber")]
                public string ReferenceNumber { get; set; }

                [JsonPropertyName("shiftId")]
                public string ShiftId { get; set; }

                [JsonPropertyName("ticketNumber")]
                public string TicketNumber { get; set; }

                [Required]
                [JsonPropertyName("transactionAmount")]
                public int TransactionAmount { get; set; }
            }

     }
}

