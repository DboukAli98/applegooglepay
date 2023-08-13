using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AppleGooglePayAPI.Models;

public class CreatePaymentIntentRequest
{
    [JsonProperty("paymentMethodType")]
    public string PaymentMethodType { get; set; }
    
    [JsonProperty("currency")]
    public string Currency { get; set; }
}