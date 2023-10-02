using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class PublishProductFailedRequest
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
