using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops
{
    public class Link
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
