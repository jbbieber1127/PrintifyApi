using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class Design : Image
    {

        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("is_selected_for_publishing")]
        public bool IsSelectedForPublishing { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

    }
}
