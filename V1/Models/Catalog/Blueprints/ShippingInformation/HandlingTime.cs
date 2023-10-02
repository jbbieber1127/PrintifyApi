using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation
{
    public class HandlingTime
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
