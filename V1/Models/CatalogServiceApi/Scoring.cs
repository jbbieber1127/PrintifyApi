using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Scoring
    {
        [JsonProperty("generic_score")]
        public double GenericScore { get; set; }

        [JsonProperty("quality")]
        public double Quality { get; set; }

        [JsonProperty("production_speed")]
        public double ProductionSpeed { get; set; }

        [JsonProperty("stock_reliability")]
        public double StockReliability { get; set; }

        [JsonProperty("courtesy")]
        public double Courtesy { get; set; }
    }
}
