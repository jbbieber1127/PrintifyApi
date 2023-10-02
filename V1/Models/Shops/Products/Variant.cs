using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class Variant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("grams")]
        public int Grams { get; set; }

        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        [JsonProperty("is_printify_express_eligible")]
        public bool IsPrintifyExpressEligible { get; set; }

        [JsonProperty("options")]
        public List<int> Options { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
