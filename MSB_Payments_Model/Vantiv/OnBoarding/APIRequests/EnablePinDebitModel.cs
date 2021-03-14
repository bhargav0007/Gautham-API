using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class EnablePinDebitModel : BaseModel
    {
        public class Root
        {
            [JsonPropertyName("enablePinDebit")]
            public bool EnablePinDebit { get; set; }
        }

    }
}
