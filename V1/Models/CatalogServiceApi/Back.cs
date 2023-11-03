using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Back
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

}