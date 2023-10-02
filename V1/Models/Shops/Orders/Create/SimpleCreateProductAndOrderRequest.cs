using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.New
{
    public class SimpleCreateProductAndOrderRequest
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("line_items")]
        public List<LineItemDetails> LineItems { get; set; }

        [JsonProperty("shipping_method")]
        public int ShippingMethod { get; set; }

        [JsonProperty("send_shipping_notification")]
        public bool SendShippingNotification { get; set; }

        [JsonProperty("address_to")]
        public AddressTo AddressTo { get; set; }
    }
}
