using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Facility
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country_label")]
        public string CountryLabel { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region_label")]
        public string RegionLabel { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }
    }
}
