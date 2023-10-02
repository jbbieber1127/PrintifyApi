using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class External
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("shipping_template_id")]
        public string ShippingTemplateId { get; set; }
    }
}
