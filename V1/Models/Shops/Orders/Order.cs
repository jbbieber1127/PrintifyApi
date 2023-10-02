using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class Order : InitiatedOrder
    {
        [JsonProperty("shop_id")]
        public int ShopId { get; set; }

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
