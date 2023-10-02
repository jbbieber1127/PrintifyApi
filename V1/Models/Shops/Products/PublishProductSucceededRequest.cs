using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class PublishProductSucceededRequest
    {
        [JsonProperty("external")]
        public External External { get; set; }
    }
}
