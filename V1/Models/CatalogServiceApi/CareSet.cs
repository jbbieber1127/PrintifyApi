using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class CareSet
    {
        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("option")]
        public string Option { get; set; }
    }
}
