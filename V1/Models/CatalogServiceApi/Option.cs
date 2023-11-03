using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Option
    {
        [JsonProperty("editor_label")]
        public string EditorLabel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("display_in_preview")]
        public bool DisplayInPreview { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("default_in_blueprint")]
        public int DefaultInBlueprint { get; set; }
    }

}