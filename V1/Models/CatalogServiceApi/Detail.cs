using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Detail
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("qualityControl")]
        public string QualityControl { get; set; }

        [JsonProperty("packaging")]
        public Packaging Packaging { get; set; }
    }

}