using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation
{
    public class ItemCost
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
