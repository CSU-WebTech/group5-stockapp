using System.Text.Json.Serialization;

namespace StockApp.Models
{
    public class StockResponse
    {
        [JsonPropertyName("meta")]
        public MetaData theMetaData { get; set; }

        [JsonPropertyName("values")]
        public StockValue[] theValues { get; set; }

        [JsonPropertyName("status")]
        public string theStatus { get; set; }
    }

    public class MetaData
    {
        [JsonPropertyName("symbol")]
        public string theSymbol { get; set; }

        [JsonPropertyName("interval")]
        public string theInterval { get; set; }

        [JsonPropertyName("currency")]
        public string theCurrency { get; set; }

        [JsonPropertyName("exchange_timezone")]
        public string theExchangeTimezone { get; set; }

        [JsonPropertyName("exchange")]
        public string theExchange { get; set; }

        [JsonPropertyName("mic_code")]
        public string theMicCode { get; set; }

        [JsonPropertyName("type")]
        public string theType { get; set; }
    }

    public class StockValue
    {
        [JsonPropertyName("datetime")]
        public string theDateTime { get; set; }

        [JsonPropertyName("open")]
        public string theOpen { get; set; }

        [JsonPropertyName("high")]
        public string theHigh { get; set; }

        [JsonPropertyName("low")]
        public string theLow { get; set; }

        [JsonPropertyName("close")]
        public string theClose { get; set; }

        [JsonPropertyName("volume")]
        public string theVolume { get; set; }
    }
}
