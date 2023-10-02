using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class PrintifyConnect
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
