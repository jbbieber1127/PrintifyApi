using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class File
    {
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }

        [JsonProperty("xsl")]
        public string Xsl { get; set; }
    }

}