using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class PrintPosition
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}
