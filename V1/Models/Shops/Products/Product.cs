using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }

        [JsonProperty("images")]
        public List<Design> Images { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("external")]
        public External External { get; set; }

        [JsonProperty("blueprint_id")]
        public int BlueprintId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("shop_id")]
        public int ShopId { get; set; }

        [JsonProperty("print_provider_id")]
        public int PrintProviderId { get; set; }

        [JsonProperty("print_areas")]
        public List<PrintArea> PrintAreas { get; set; }

        [JsonProperty("print_details")]
        public List<object> PrintDetails { get; set; }

        [JsonProperty("sales_channel_properties")]
        public List<object> SalesChannelProperties { get; set; }

        [JsonProperty("is_printify_express_eligible")]
        public bool IsPrintifyExpressEligible { get; set; }
    }
}
