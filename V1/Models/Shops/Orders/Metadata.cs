using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class Metadata
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("variant_label")]
        public string VariantLabel { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("shop_order_id")]
        public string ShopOrderId { get; set; }

        [JsonProperty("shop_order_label")]
        public string ShopOrderLabel { get; set; }

        [JsonProperty("shop_fulfilled_at")]
        public string ShopFulfilledAt { get; set; }
    }
}
