using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Feature
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_id")]
        public int ImageId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

}