using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation
{
    public class Profile
    {
        [JsonProperty("variant_ids")]
        public List<int> VariantIds { get; set; }

        [JsonProperty("first_item")]
        public ItemCost FirstItem { get; set; }

        [JsonProperty("additional_items")]
        public ItemCost AdditionalItems { get; set; }

        [JsonProperty("countries")]
        public List<string> Countries { get; set; }
    }
}
