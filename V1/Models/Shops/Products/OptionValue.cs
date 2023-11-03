using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class OptionValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }
    }
}
