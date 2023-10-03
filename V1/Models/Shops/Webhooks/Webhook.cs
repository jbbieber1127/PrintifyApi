using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Webhooks
{
    public class Webhook
    {
        [JsonProperty("id")]
        string Id { get; set; }

        [JsonProperty("shop_id")]
        int ShopId { get; set; }

        [JsonProperty("topic")]
        string Topic { get; set; }

        [JsonProperty("url")]
        string Url { get; set; }
    }
}
