using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public abstract class LineItem : LineItemBase
    {

        [JsonProperty("print_provider_id")]
        public int PrintProviderId { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }
    }
}
