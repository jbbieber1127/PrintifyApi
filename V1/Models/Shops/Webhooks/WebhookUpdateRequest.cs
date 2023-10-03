using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Webhooks
{
    public class WebhookUpdateRequest
    {

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
