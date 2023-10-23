using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Seo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("socialImage")]
        public string SocialImage { get; set; }
    }
}
