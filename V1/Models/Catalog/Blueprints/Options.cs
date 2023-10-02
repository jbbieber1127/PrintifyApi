using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints
{
    public class Options
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
