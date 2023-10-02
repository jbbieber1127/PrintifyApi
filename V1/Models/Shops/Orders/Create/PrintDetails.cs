using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class PrintDetails
    {

        [JsonProperty("print_on_side")]
        public string PrintOnSide { get; set; }
    }
}
