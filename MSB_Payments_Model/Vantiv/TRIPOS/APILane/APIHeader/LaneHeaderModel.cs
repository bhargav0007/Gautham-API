using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.TRIPOS.APILane.APIHeader

{
    [Serializable]
    public class LaneHeaderModel : BaseModel
    {
        [Required]
        [JsonPropertyName("tp-application-id")]
        public string Tp_application_id { get; set; }
        [Required]
        [JsonPropertyName("tp-application-name")]
        public string Tp_application_name { get; set; }
        [Required]
        [JsonPropertyName("tp-application-version")]
        public string Tp_application_version { get; set; }
        [Required]
        [JsonPropertyName("tp-express-acceptor-id")]
        public string Tp_express_acceptor_id { get; set; }
        [Required]
        [JsonPropertyName("tp-express-account-id")]
        public string Tp_express_account_id { get; set; }
        [Required]
        [JsonPropertyName("tp-express-account-token")]
        public string Tp_express_account_token { get; set; }
        [Required]
        [JsonPropertyName("tp-request-id")]
        public string Tp_request_id { get; set; }
    }
}
