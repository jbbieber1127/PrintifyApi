using Newtonsoft.Json;
namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class LineItemDetails : LineItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("shipping_cost")]
        public int ShippingCost { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("sent_to_production_at")]
        public string SentToProductionAt { get; set; }

        [JsonProperty("fulfilled_at")]
        public string FulfilledAt { get; set; }
    }
}
