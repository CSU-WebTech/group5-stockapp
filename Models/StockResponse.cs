using System.Text.Json.Serialization;

namespace StockApp.Models
{
    public record StockResponse
    {
        [JsonPropertyName("symbol")]
        public string theSymbol {get; init;}

        [JsonPropertyName("name")]
        public string theName {get; init;}

        [JsonPropertyName("currency")]
        public string theCurrency {get; init;}

        [JsonPropertyName("exchange")]
        public string theExchange {get; init;}

        [JsonPropertyName("mic_code")]
        public string theMic_code {get; init;}

        [JsonPropertyName("country")]
        public string theCountry {get; init;}

        [JsonPropertyName("type")]
        public string theType {get; init;}
    }
}
