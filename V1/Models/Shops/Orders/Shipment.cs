using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class Shipment
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("delivered_at")]
        public object DeliveredAt { get; set; }
    }
}
