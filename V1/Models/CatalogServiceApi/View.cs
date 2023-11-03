using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class View
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("area_icon")]
        public string AreaIcon { get; set; }

        [JsonProperty("files")]
        public List<File> Files { get; set; }

        [JsonProperty("can_upload")]
        public bool CanUpload { get; set; }

        [JsonProperty("show_layer_info")]
        public bool ShowLayerInfo { get; set; }
    }

}