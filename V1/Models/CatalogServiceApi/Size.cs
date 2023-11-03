using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Size
    {
        [JsonProperty("placeholder_id")]
        public string PlaceholderId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("rotation")]
        public double Rotation { get; set; }

        [JsonProperty("offsetx")]
        public double Offsetx { get; set; }

        [JsonProperty("offsety")]
        public double Offsety { get; set; }

        [JsonProperty("min_dpi")]
        public int MinDpi { get; set; }

        [JsonProperty("recommended_dpi")]
        public int RecommendedDpi { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }
    }

}