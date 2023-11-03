using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Cost
    {
        [JsonProperty("blank")]
        public double Blank { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("printing")]
        public double Printing { get; set; }

        [JsonProperty("placeholders")]
        public List<string> Placeholders { get; set; }

        [JsonProperty("result")]
        public double Result { get; set; }

        [JsonProperty("resultSubscription")]
        public double ResultSubscription { get; set; }
    }
}
