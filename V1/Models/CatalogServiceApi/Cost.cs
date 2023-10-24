using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Cost
    {
        [JsonProperty("blank")]
        public int Blank { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("margin")]
        public int Margin { get; set; }

        [JsonProperty("printing")]
        public int Printing { get; set; }

        [JsonProperty("placeholders")]
        public List<string> Placeholders { get; set; }

        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("resultSubscription")]
        public int ResultSubscription { get; set; }
    }
}
