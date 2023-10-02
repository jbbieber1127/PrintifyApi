using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{

    public class Value
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("colors")]
        public List<string> Colors { get; set; }
    }

}