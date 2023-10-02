using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shop_id")]
        public int ShopId { get; set; }

        [JsonProperty("address_to")]
        public AddressTo AddressTo { get; set; }

        [JsonProperty("line_items")]
        public List<LineItemDetails> LineItems { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("total_price")]
        public int TotalPrice { get; set; }

        [JsonProperty("total_shipping")]
        public int TotalShipping { get; set; }

        [JsonProperty("total_tax")]
        public int TotalTax { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipping_method")]
        public int ShippingMethod { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("sent_to_production_at")]
        public string SentToProductionAt { get; set; }

        [JsonProperty("fulfilled_at")]
        public string FulfilledAt { get; set; }

        [JsonProperty("fulfilment_type")]
        public string FulfilmentType { get; set; }

        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }

        [JsonProperty("printify_connect")]
        public PrintifyConnect PrintifyConnect { get; set; }
    }
}
