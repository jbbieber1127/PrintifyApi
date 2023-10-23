using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Details
    {
        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("qualityControl")]
        public string QualityControl { get; set; }

        [JsonProperty("packaging")]
        public Packaging Packaging { get; set; }
    }
}
