using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints
{
    public class Variant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("placeholders")]
        public List<Placeholder> Placeholders { get; set; }
    }
}
