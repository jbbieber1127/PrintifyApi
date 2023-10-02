using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints
{
    public class VariantsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }
    }
}
