using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints
{
    public class Placeholder
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
