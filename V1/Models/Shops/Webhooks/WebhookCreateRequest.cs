using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Webhooks
{
    public class WebhookCreateRequest : WebhookUpdateRequest
    {

        [JsonProperty("topic")]
        public string? Topic { get; set; }
    }
}
