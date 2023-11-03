using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Type2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("ranges")]
        public List<Range> Ranges { get; set; }
    }

}