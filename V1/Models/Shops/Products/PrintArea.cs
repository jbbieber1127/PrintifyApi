using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class PrintArea
    {
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        [JsonProperty("placeholders")]
        public List<Placeholder> Placeholders { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("font_family")]
        public string FontFamily { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }
    }
}
