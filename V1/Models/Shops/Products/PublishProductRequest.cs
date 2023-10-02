using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class PublishProductRequest
    {
        [JsonProperty("title")]
        public bool Title { get; set; }

        [JsonProperty("description")]
        public bool Description { get; set; }

        [JsonProperty("images")]
        public bool Images { get; set; }

        [JsonProperty("variants")]
        public bool Variants { get; set; }

        [JsonProperty("tags")]
        public bool Tags { get; set; }

        [JsonProperty("keyFeatures")]
        public bool KeyFeatures { get; set; }

        [JsonProperty("shipping_template")]
        public bool ShippingTemplate { get; set; }
    }
}
