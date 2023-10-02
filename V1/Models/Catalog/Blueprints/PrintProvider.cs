using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints
{
    public class PrintProvider
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("location")]
        public Location? Location { get; set; }

        [JsonProperty("blueprints")]
        public List<Blueprint>? Blueprints { get; set; }
    }
}
