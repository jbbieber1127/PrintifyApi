using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("colorGroup")]
        public ColorGroup ColorGroup { get; set; }

        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }
    }
}
