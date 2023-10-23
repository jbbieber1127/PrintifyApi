using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class ManagedTag
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("promotional")]
        public bool Promotional { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("icon")]
        public object Icon { get; set; }
    }
}
