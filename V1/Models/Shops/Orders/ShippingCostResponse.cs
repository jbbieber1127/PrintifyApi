using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public class ShippingCostResponse
    {
        [JsonProperty("standard")]
        public int Standard { get; set; }

        [JsonProperty("express")]
        public int Express { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("printify_express")]
        public int PrintifyExpress { get; set; }
    }
}
