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
    }
}
