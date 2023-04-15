using System.Text.Json.Serialization;

namespace StockApp.Models
{
    public class StockResponse
    {
        [JsonPropertyName("data")]
        public StockData[] theData { get; set; }

        [JsonPropertyName("status")]
        public string theStatus { get; set; }
    }

    public class StockData
    {
        [JsonPropertyName("symbol")]
        public string theSymbol { get; set; }

        [JsonPropertyName("name")]
        public string theName { get; set; }

        [JsonPropertyName("currency")]
        public string theCurrency { get; set; }

        [JsonPropertyName("exchange")]
        public string theExchange { get; set; }

        [JsonPropertyName("mic_code")]
        public string theMicCode { get; set; }

        [JsonPropertyName("country")]
        public string theCountry { get; set; }

        [JsonPropertyName("type")]
        public string theType { get; set; }
    }
}
