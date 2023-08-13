using Newtonsoft.Json;

namespace AppleGooglePayAPI.Models.ResponseModels;

public class CreatePaymentIntentResponseModel
{
    [JsonProperty("clientSecret")]
    public string ClientSecret { get; set; }
}