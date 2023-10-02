using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation
{
    public class ShippingInformation
    {
        [JsonProperty("handling_time")]
        public HandlingTime HandlingTime { get; set; }

        [JsonProperty("profiles")]
        public List<Profile> Profiles { get; set; }
    }
}
