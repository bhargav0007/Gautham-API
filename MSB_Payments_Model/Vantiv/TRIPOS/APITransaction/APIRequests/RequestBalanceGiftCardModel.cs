using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class RequestBalanceGiftCardModel : BaseModel
    {
        public class Configuration
        {
            public bool AllowPartialApprovals { get; set; }
            public bool CheckForDuplicateTransactions { get; set; }
            public string MarketCode { get; set; }
        }

        public class StoreCard
        {
            public string Id { get; set; }
            public string Password { get; set; }
        }

        public class Root
        {
            public string CardHolderPresentCode { get; set; }
            public string ClerkNumber { get; set; }
            public Configuration Configuration { get; set; }
            public string EbtType { get; set; }
            public bool InvokeManualEntry { get; set; }
            public string IsCscSupported { get; set; }
            public string IsGiftSupported { get; set; }
            [Required]
            public int LaneId { get; set; }
            public string ReferenceNumber { get; set; }
            public string ShiftId { get; set; }
            public StoreCard StoreCard { get; set; }
            public string TicketNumber { get; set; }
        }
    }
}
