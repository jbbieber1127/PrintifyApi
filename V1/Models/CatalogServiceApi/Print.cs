using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Print
    {
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        [JsonProperty("font_family")]
        public string FontFamily { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("made_of")]
        public string MadeOf { get; set; }

        [JsonProperty("publisher_group_images_by")]
        public string PublisherGroupImagesBy { get; set; }

        [JsonProperty("transparent_layer")]
        public bool TransparentLayer { get; set; }

        [JsonProperty("use_map_alpha")]
        public string UseMapAlpha { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("placeholders")]
        public List<Placeholder> Placeholders { get; set; }
    }

}