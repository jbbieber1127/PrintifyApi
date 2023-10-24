using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Shipping
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("additional")]
        public int Additional { get; set; }

        [JsonProperty("first")]
        public int First { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("destinationGroupId")]
        public int DestinationGroupId { get; set; }

        [JsonProperty("destinationGroupLabel")]
        public string DestinationGroupLabel { get; set; }
    }
}
