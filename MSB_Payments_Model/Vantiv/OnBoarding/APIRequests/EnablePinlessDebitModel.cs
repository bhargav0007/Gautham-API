using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnablePinlessDebitModel : BaseModel

    {
        public class Root
        {
            [JsonPropertyName("enablePinlessDebit")]
            public bool EnablePinlessDebit { get; set; }
        }

    }
}
