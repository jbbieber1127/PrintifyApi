using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Image
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("catalog_preview")]
        public List<string> CatalogPreview { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }
    }

}