using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class OrderRequest : ShippingRequest
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("shipping_method")]
        public int ShippingMethod { get; set; }

        [JsonProperty("send_shipping_notification")]
        public bool SendShippingNotification { get; set; }

    }
}
