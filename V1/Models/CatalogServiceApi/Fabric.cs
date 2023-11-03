using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Fabric
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }
    }

}