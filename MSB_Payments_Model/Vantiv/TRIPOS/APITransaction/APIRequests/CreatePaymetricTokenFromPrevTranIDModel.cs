using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APITransaction.APIRequests
{
    [Serializable]
    public class CreatePaymetricTokenFromPrevTranIDModel : BaseModel
    {
      
        public class Root
        {
            [Required]
            [JsonPropertyName("laneId")]
            public int LaneId { get; set; }
            [Required]
            [JsonPropertyName("vaultId")]
            public string VaultId { get; set; }
        }


    }
}
