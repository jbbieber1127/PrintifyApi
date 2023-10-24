using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class SizeGuide
    {
        [JsonProperty("sizes")]
        public List<string> Sizes { get; set; }

        [JsonProperty("types")]
        public List<Type> Types { get; set; }
    }
}
