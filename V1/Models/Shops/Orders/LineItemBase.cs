using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders
{
    public abstract class LineItemBase
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
