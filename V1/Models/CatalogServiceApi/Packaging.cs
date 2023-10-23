using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Packaging
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("files")]
        public List<string> Files { get; set; }
    }
}
