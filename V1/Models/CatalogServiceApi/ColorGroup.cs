using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class ColorGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

}