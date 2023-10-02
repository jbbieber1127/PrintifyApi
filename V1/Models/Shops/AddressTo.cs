using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops
{
    public class AddressTo : Location
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("company")]
        public object Company { get; set; }
    }
}
