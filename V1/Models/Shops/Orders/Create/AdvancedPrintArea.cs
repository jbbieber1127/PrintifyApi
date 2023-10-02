using Newtonsoft.Json;
using PrintifyApi.V1.Models.Shops.Products;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class AdvancedPrintArea
    {

        [JsonProperty("front")]
        public List<Image> Front { get; set; }
    }
}
