using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class PrintProvider
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("minPrice")]
        public int MinPrice { get; set; }

        [JsonProperty("minPriceSubscription")]
        public int MinPriceSubscription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoDaysDeliveryEnabled")]
        public bool TwoDaysDeliveryEnabled { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("bulkDiscountEnabled")]
        public bool BulkDiscountEnabled { get; set; }

        [JsonProperty("averageBusinessDaysInProduction")]
        public double AverageBusinessDaysInProduction { get; set; }

        [JsonProperty("location")]
        public PrintProviderLocation Location { get; set; }

        [JsonProperty("rankingScore")]
        public int RankingScore { get; set; }

        [JsonProperty("printPosition")]
        public List<PrintPosition> PrintPosition { get; set; }

        [JsonProperty("scoring")]
        public Scoring Scoring { get; set; }

        [JsonProperty("shipping")]
        public List<Shipping> Shipping { get; set; }

        [JsonProperty("minShipping")]
        public int MinShipping { get; set; }

        [JsonProperty("brandingFeatures")]
        public List<BrandingFeature> BrandingFeatures { get; set; }

        [JsonProperty("facilities")]
        public List<Facility> Facilities { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }
}
