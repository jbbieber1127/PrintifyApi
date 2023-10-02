using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class SimplePrintArea
    {

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
