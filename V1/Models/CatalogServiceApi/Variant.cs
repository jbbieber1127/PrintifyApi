using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Variant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("options")]
        public List<int> Options { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("availablePrintProviders")]
        public List<string> AvailablePrintProviders { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("costs")]
        public List<Cost> Costs { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }


        [JsonProperty("on")]
        public int On { get; set; }


        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }


        [JsonProperty("profit")]
        public int Profit { get; set; }

    }
}
