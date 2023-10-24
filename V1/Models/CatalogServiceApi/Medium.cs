using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Medium
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("catalogPreview")]
        public List<string> CatalogPreview { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }
    }
}
