using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("color_group")]
        public ColorGroup ColorGroup { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fabrics")]
        public List<Fabric> Fabrics { get; set; }

        [JsonProperty("made_of")]
        public string MadeOf { get; set; }

        [JsonProperty("sizes")]
        public List<Size> Sizes { get; set; }
    }

}