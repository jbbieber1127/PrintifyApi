using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class Placeholder
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("images")]
        public List<Design> Images { get; set; }
    }
}
